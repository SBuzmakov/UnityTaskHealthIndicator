using Source.Scripts.AttributesScripts;
using UnityEngine;
using UnityEngine.UI;

namespace Source.Scripts.Services
{
    public abstract class ButtonInteractor : MonoBehaviour 
    {
        [SerializeField] private Button _button;
        [SerializeField] private Health _health;

        public void OnEnable()
        {
            _button.onClick.AddListener(Interact);
        }

        public void OnDisable()
        {
            _button.onClick.RemoveListener(Interact);
        }
        
        private void Interact()
        {
            Act(_health);
        }
        
        protected abstract void Act(Health health);
    }
}
