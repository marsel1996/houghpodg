using Assets.Scripts.Common;

namespace Assets.Scripts.Contracts
{
    public abstract class Enemy : Unit
    {
        public abstract void Die();
        public abstract void DestroyBody();
    }
}