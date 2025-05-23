using System.Globalization;
using TMPro;

namespace Source.Scripts.UIScripts
{
    public class HealthTextViewer 
    {
        private TextMeshProUGUI _healthText;

        public HealthTextViewer(TextMeshProUGUI healthText)
        {
            _healthText = healthText;
        }
        
        public void SetHealthView(float currentHealth, float maxHealth)
        {
            _healthText.text = $"{currentHealth.ToString(CultureInfo.CurrentCulture)} / {maxHealth.ToString(CultureInfo.CurrentCulture)}";
        }
    }
}
