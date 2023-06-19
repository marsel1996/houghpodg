using UnityEngine;

namespace Assets.Scripts.Contracts
{
    public abstract class Bullet : UnitCauseDamage
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _flyTime;

        public float Speed => _speed;
        public float FlyTime => _flyTime;
    }
}