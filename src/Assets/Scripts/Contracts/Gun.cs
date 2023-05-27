using UnityEngine;

namespace Assets.Scripts.Contracts
{
    public abstract class Gun : Weapon
    {
        [SerializeField] private float _cooldown;
        [SerializeField] private float _delay;
        [SerializeField] private Bullet _prefabBullet;

        public float Cooldown => _cooldown;
        public float Delay => _delay;
    }
}