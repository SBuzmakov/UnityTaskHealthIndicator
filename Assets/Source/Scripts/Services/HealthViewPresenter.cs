using Source.Scripts.PlayerScripts;
using Source.Scripts.UIScripts;
using UnityEngine;

namespace Source.Scripts.Services
{
    public class HealthViewPresenter
    {
        private readonly Player _player;
        private readonly HealthTextViewer _healthTextViewer;
        private readonly HealthBarViewer _healthBarViewer1;
        private readonly HealthBarViewer _healthBarViewer2;

        Coroutine _coroutine;
        
        public HealthViewPresenter(Player player, HealthTextViewer healthTextViewer, HealthBarViewer healthBarViewer1, HealthBarViewer healthBarViewer2)
        {
            _player = player;
            _healthTextViewer = healthTextViewer;
            _healthBarViewer1 = healthBarViewer1;
            _healthBarViewer2 = healthBarViewer2;
        }

        public void Initialize()
        {
            SetHealthView();
            
            _player.HealthChanged += SetHealthView;
        }

        public void Dispose()
        {
            _player.HealthChanged -= SetHealthView;
        }

        private void SetHealthView()
        {
            _healthTextViewer.SetHealthView(_player.GetCurrentHealth(), _player.GetMaxHealth());
            
            _healthBarViewer1.SetHealthView(_player.GetCurrentHealth(), _player.GetMaxHealth());
            
            _healthBarViewer2.SetHealthView(_player.GetCurrentHealth(), _player.GetMaxHealth());
        }
    }
}
