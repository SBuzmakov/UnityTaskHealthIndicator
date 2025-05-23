using System;
using Source.Scripts.PlayerScripts;
using UnityEngine;
using UnityEngine.UI;

namespace Source.Scripts.MedicineChestScripts
{
    public class Healer : MonoBehaviour
    {
        [SerializeField] private float _healValue;
        [SerializeField] private Button _healButton;

        public event Action ButtonClicked;

        private void OnEnable()
        {
            _healButton.onClick.AddListener(() =>ButtonClicked?.Invoke());
        }

        private void OnDisable()
        {
            _healButton.onClick.RemoveAllListeners();
        }
        
        public void Heal(Player player)
        {
            player.Heal(_healValue);
        }

    }
}
