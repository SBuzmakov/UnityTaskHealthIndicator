using Source.Scripts.EnemyScripts;
using Source.Scripts.MedicineChestScripts;
using Source.Scripts.PlayerScripts;
using Source.Scripts.UIScripts;
using TMPro;
using UnityEngine;

namespace Source.Scripts.Services
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private TextMeshProUGUI _healthText;
        [SerializeField] private Damager _damager;
        [SerializeField] private Healer _healer;
        [SerializeField] private HealthBarViewer _healthBarViewer1;
        [SerializeField] private HealthBarViewer _healthBarViewer2;

        private HealthViewPresenter _healthViewPresenter;
        private HealthTextViewer _healthTextViewer;
        private ButtonsPresenter _buttonsPresenter;
        
        private void Awake()
        {
            _player.Initialize();
            
            _healthTextViewer = new HealthTextViewer(_healthText);
            
            _healthViewPresenter = new HealthViewPresenter(_player, _healthTextViewer, _healthBarViewer1, _healthBarViewer2);
            _healthViewPresenter.Initialize();
            
            _buttonsPresenter = new ButtonsPresenter(_player, _damager, _healer);
            _buttonsPresenter.Initialize();
        }

        private void OnDestroy()
        {
            _healthViewPresenter.Dispose();
            _buttonsPresenter.Dispose();
        }
    }
}
