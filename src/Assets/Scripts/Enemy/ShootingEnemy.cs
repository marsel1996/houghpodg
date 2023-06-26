using Assets.Scripts.Common;
using Assets.Scripts.Contracts;
using UnityEngine;

namespace Assets.Scripts.Enemy
{
    public class ShootingEnemy : Contracts.Enemy
    {
        [SerializeField] private RotationByTargetPosition _rotateScript;
        [SerializeField] private BoxCollider2D _body;
        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private Gun _gun;

        private float _timer = 0;

        public RotationByTargetPosition RotateScript => _rotateScript;

        public override void Die()
        {
            _rotateScript.enabled = false;
            Remove(gameObject);
        }

        public override void DestroyBody()
        {
            Remove(_rb);
            Remove(_body);
        }

        private void FixedUpdate()
        {
            if (_timer <= 0)
            {
                _gun.Attack();
                _timer = _gun.Delay;
            }
            else
            {
                _timer -= Time.deltaTime;
            }
        }
    }
}