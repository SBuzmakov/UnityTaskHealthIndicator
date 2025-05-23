using Source.Scripts.EnemyScripts;
using Source.Scripts.MedicineChestScripts;
using Source.Scripts.PlayerScripts;

namespace Source.Scripts.Services
{
    public class ButtonsPresenter 
    {
        private readonly Player _player;
        private readonly Damager _damager;
        private readonly Healer _healer;
        
        public ButtonsPresenter(Player player, Damager damager, Healer healer)
        {
            _player = player;
            _damager = damager;
            _healer = healer;
        }

        public void Initialize()
        {
            _damager.ButtonClicked += GiveDamageToPlayer;
            _healer.ButtonClicked += HealPlayer;
        }

        public void Dispose()
        {
            _damager.ButtonClicked -= GiveDamageToPlayer;
            _healer.ButtonClicked -= HealPlayer;
        }
        
        private void GiveDamageToPlayer()
        {
            _damager.GiveDamage(_player);
        }

        private void HealPlayer()
        {
            _healer.Heal(_player);
        }
    }
}
