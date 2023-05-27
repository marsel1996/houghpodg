namespace Assets.Scripts.Contracts
{
    public abstract class HolderFactory : IHolderFactory
    {
        public abstract Holder CreateHolder();
    }
}
