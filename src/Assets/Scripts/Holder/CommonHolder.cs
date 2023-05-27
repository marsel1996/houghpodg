using UnityEngine;

namespace Assets.Scripts.Holder
{
    public class CommonHolder : Contracts.Holder
    {
        [SerializeField] private Transform _weaponPoint;

        public override Transform WeaponPoint => _weaponPoint;
    }
}