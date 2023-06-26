using UnityEngine;

namespace Assets.Scripts.Weapon.Enemy
{
    public class EnemyBareHands : Contracts.Weapon
    {
        [SerializeField] private EnemyBareHandsDamage _damageZone;

        public override void Attack()
        {
            print("kiya kiya enemy");
        }

        public override void Remove(bool withGameObject = false)
        {
            _damageZone.Remove(true);
            base.Remove(withGameObject);
        }
    }
}