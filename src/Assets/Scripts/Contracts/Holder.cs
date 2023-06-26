using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Contracts
{
    public abstract class Holder : Unit
    {
        public abstract Transform WeaponPoint { get; }
    }
}