using System;
using Source.Scripts.AttributesScripts;
using UnityEngine;

namespace Source.Scripts.PlayerScripts
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _maxHealth;
        
        private Health _health;
        
        public event Action HealthChanged;
        
        public void Initialize()
        {
            _health = new Health();
            _health.Initialize(_maxHealth);
        }

        public float GetCurrentHealth()
        {
            return _health.CurrentHealth;
        }

        public float GetMaxHealth()
        {
            return _maxHealth;
        }

        public void TakeDamage(float damage)
        {
            _health.TakeDamage(damage);
            HealthChanged?.Invoke();
        }

        public void Heal(float healValue)
        {
            _health.Heal(healValue);
            HealthChanged?.Invoke();
        }
    }
}
