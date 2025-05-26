using Source.Scripts.AttributesScripts;
using UnityEngine;

namespace Source.Scripts.PlayerScripts
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private float _maxHealth;
        [SerializeField] private Health _health;
        
        public Health Health => _health;
        
        public void Initialize()
        {
            _health.Initialize(_maxHealth);
        }
    }
}
