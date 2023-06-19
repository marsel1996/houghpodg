using Assets.Scripts.Common.Factory;
using Assets.Scripts.Contracts;

namespace Assets.Scripts.Holder.Factory
{
    public class WithPistolHolderFactory : HolderFactory
    {
        public override Contracts.Holder CreateHolder()
        {
            return CharacterHolderPrefabs.Initialize().WithPistolHolder;
        }
    }
}