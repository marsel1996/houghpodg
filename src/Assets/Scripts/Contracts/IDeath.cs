namespace Assets.Scripts.Contracts
{
    public interface IDeath
    {
        public delegate void Dead();
        public event Dead OnDead;
    }
}
