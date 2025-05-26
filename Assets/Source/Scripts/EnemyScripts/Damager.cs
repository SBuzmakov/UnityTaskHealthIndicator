using Source.Scripts.AttributesScripts;
using Source.Scripts.Services;
using UnityEngine;

namespace Source.Scripts.EnemyScripts
{
    public class Damager : ButtonInteractor
    {
        [SerializeField] private float _damage; 
        
        protected override void Act(Health health)
        {
            health.TakeDamage(_damage);
        }
    }
}