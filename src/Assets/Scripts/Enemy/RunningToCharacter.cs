using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Enemy
{
    public class RunningToCharacter : Unit
    {
        [SerializeField] private Character.Character _target;
        [SerializeField] private float _speed;
        private Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }

        private void Start()
        {
            _target = GameConfig.Initialize().GetCharacter();
        }

        private void FixedUpdate()
        {
            var targetPosition = _target.Transform.position;
            var currentPosition = _transform.position;

            _transform.position = Vector2.MoveTowards(currentPosition, targetPosition, _speed * Time.deltaTime);
        }
    }
}