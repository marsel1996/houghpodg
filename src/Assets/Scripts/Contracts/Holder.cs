using UnityEngine;

namespace Assets.Scripts.Contracts
{
    public abstract class Holder : MonoBehaviour
    {
        public abstract Transform WeaponPoint { get; }
    }
}