using Source.Scripts.AttributesScripts;
using Source.Scripts.Services;
using UnityEngine;

namespace Source.Scripts.MedicineChestScripts
{
    public class Healer : ButtonInteractor
    {
        [SerializeField] private float _healValue; 
        
        protected override void Act(Health health)
        {
            health.Heal(_healValue);
        }
    }
}