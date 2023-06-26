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

        public override void Attack()
        {
            var bullet = CreateBullet();
            BulletMove(bullet);
        }
        
        protected Bullet CreateBullet()
        {
            var bullet = Instantiate(_prefabBullet, _firePoint.position, _firePoint.rotation);
            return bullet;
        }

        protected BulletMover BulletMove(Bullet bullet)
        {
            return bullet.gameObject.AddComponent<BulletMover>();
        }
    }
}