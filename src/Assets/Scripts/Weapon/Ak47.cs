using Assets.Scripts.Contracts;
using UnityEngine;

namespace Assets.Scripts.Weapon
{
    public class Ak47 : AutomaticGun
    {
        public override void Attack(MonoBehaviour owner)
        {
            print("pif pif");
            base.Attack(owner);
        }
    }
}