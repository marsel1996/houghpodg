using Assets.Scripts.Weapon.Bullet;
using UnityEngine;

namespace Assets.Scripts.Contracts
{
    public abstract class Gun : Weapon
    {
        [SerializeField] private float _cooldown;
        [SerializeField] private float _delay;
        [SerializeField] private Bullet _prefabBullet;
        [SerializeField] private Transform _firePoint;

        public float Cooldown => _cooldown;
        public float Delay => _delay;
        public Transform FirePoint => _firePoint;

        public override void Attack(MonoBehaviour owner)
        {
            var bullet = CreateBullet(owner);
            BulletMove(bullet);
        }
        
        protected Bullet CreateBullet(MonoBehaviour owner)
        {
            var bullet = Instantiate(_prefabBullet, FirePoint.position, Carrier.rotation);
            bullet.Owner = owner;
            return bullet;
        }

        protected BulletMover BulletMove(Bullet bullet)
        {
            return bullet.gameObject.AddComponent<BulletMover>();
        }
    }
}