using Assets.Scripts.Common;
using Assets.Scripts.Contracts;

namespace Assets.Scripts.Holder.Factory
{
    public class WithAutomatHolderFactory : HolderFactory
    {
        public override Contracts.Holder CreateHolder()
        {
            return HolderPrefabs.Initialize().WithAutomatHolder;
        }
    }
}