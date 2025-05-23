using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Source.Scripts.UIScripts
{
    public class HealthBarViewer : MonoBehaviour
    {
        [SerializeField] private Image _healthBar;
        [SerializeField] private float _changingSpeed;
        [SerializeField] private bool _isChangingSmooth;

        private Coroutine _coroutine;

        public void SetHealthView(float targetHealth, float maxHealth)
        {
            if (_isChangingSmooth)
            {
                if (_coroutine != null)
                    StopCoroutine(_coroutine);

                _coroutine = StartCoroutine((StartSmoothChangingHealth(targetHealth, maxHealth)));
            }
            else
            {
                SetHealthViewRapid(targetHealth, maxHealth);
            }
        }

        private IEnumerator StartSmoothChangingHealth(float targetHealth, float maxHealth)
        {
            float targetHealthView = targetHealth / maxHealth;

            while (!Mathf.Approximately(_healthBar.fillAmount, targetHealthView))
            {
                _healthBar.fillAmount = Mathf.MoveTowards(_healthBar.fillAmount, targetHealthView, _changingSpeed);

                yield return null;
            }
            
            _coroutine = null;
        }

        private void SetHealthViewRapid(float targetHealth, float maxHealth)
        {
            _healthBar.fillAmount = targetHealth / maxHealth;
        }
    }
}