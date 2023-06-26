using UnityEngine;
using Assets.Scripts.Common;

namespace Assets.Scripts.Weapon.Bullet
{
    public class BulletMover : Unit
    {
        [SerializeField] private float _currentTime = 0;
        private Transform _transform;
        private Contracts.Bullet _bullet;

        private float Speed => _bullet.Speed;
        private float FlyTime => _bullet.FlyTime;

        private void Start()
        {
            _transform = transform;
            _bullet = GetComponent<Contracts.Bullet>();
        }

        private void FixedUpdate()
        {
            _transform.Translate(Vector3.right * Speed * Time.deltaTime);
            _currentTime += Time.deltaTime;

            if (_currentTime >= FlyTime)
            {
                _bullet.Remove(true);
            } 
        }
    }
}