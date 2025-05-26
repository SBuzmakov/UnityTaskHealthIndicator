using System.Collections.Generic;
using System.ComponentModel.Design;
using Source.Scripts.AttributesScripts;
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
        [SerializeField] private Character _character;
        [SerializeField] private HealthTextViewer _healthTextViewer;
        [SerializeField] private HealthBarRapidViewer _healthBarRapidViewer;
        [SerializeField] private HealthBarSmoothViewer _healthBarSmoothViewer;
        
        private List<IHealthViewable> _healthViewers;
        private HealthViewPresenter _healthViewPresenter;
        
        private void Awake()
        {
            _healthViewers = new List<IHealthViewable> {_healthTextViewer, _healthBarRapidViewer, _healthBarSmoothViewer};
            
            _character.Initialize();

            _healthViewPresenter = new HealthViewPresenter(_character.Health, _healthViewers);
            _healthViewPresenter.Initialize();
        }

        private void OnDestroy()
        {
            _healthViewPresenter.Dispose();
        }
    }
}
