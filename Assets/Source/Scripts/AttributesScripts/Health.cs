namespace Source.Scripts.AttributesScripts
{
    public class Health
    {
        public float MaxHealth { get; private set; }
        public float CurrentHealth { get; private set; }

        public void Initialize(float maxHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
        }

        public void TakeDamage(float damage)
        {
            if (damage < 0f)
                return;
            
            if (CurrentHealth - damage < 0f)
                CurrentHealth = 0f;
            else
                CurrentHealth -= damage;
        }

        public void Heal(float healValue)
        {
            if (healValue < 0f)
                return;

            if (CurrentHealth + healValue > MaxHealth)
                CurrentHealth = MaxHealth;
            else
                CurrentHealth += healValue;
        }
    }
}