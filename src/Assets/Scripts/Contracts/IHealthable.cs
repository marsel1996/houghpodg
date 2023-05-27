namespace Assets.Scripts.Contracts
{
    public interface IHealthable
    {
        public delegate void HealthChanged();
        public event HealthChanged OnHealthChanged;

        public float Health { get; }
        public float CurrentHealth { get; }

        public void AddCurrentHealth(float value);
    }
}
