using UnityEngine;

namespace Assets.Scripts.Common
{
    public class RotationByTarget : Unit
    {
        [SerializeField] private Transform _target;
        private Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }

        private void Start()
        {
            _target = GameConfig.Initialize().GetCharacter().Body;
        }

        private void FixedUpdate()
        {
            var vactorToTarget = _target.position - _transform.position;
            var angle = -Mathf.Atan2(vactorToTarget.y, vactorToTarget.x) * Mathf.Rad2Deg;
            angle = angle >= 90 && angle <= 120
                ? 120
                : angle <= 90 && angle >= 60
                    ? 60
                    : angle;

            if (angle >= 120)
            {
                _transform.rotation = Quaternion.Euler(new Vector3(0, 180, -(180 - angle)));
            } else
            {
                _transform.rotation = Quaternion.Euler(new Vector3(0, 0, -angle));
            }
        }
    }
}