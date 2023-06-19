using Assets.Scripts.Contracts;
using UnityEngine;

namespace Assets.Scripts.Weapon
{
    public class Makarov : CommonGun
    {
        public override void Attack(MonoBehaviour owner)
        {
            print("paf paf");
            base.Attack(owner);
        }
    }
}