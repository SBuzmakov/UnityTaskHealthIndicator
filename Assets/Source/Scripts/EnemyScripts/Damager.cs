using System;
using Source.Scripts.PlayerScripts;
using UnityEngine;
using UnityEngine.UI;

namespace Source.Scripts.EnemyScripts
{
    public class Damager : MonoBehaviour
    {
        [SerializeField] private float _damage;
        [SerializeField] private Button _giveDamageButton;

        public event Action ButtonClicked;

        private void OnEnable()
        {
            _giveDamageButton.onClick.AddListener(() =>ButtonClicked?.Invoke());
        }

        private void OnDisable()
        {
            _giveDamageButton.onClick.RemoveAllListeners();
        }
        
        public void GiveDamage(Player player)
        {
            player.TakeDamage(_damage);
        }
    }
}
