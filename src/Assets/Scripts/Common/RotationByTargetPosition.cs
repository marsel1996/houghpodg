using UnityEngine;

namespace Assets.Scripts.Common
{
    public class RotationByTargetPosition : Unit
    {
        [SerializeField] private Character.Character _target;
        [SerializeField] private Transform _staticContent;
        private Transform _transform;

        public override void Remove(bool withGameObject = false)
        {
            Rotate();
            base.Remove(withGameObject);
        }

        private void Rotate()
        {
            if (_target.Transform.position.x >= _transform.position.x)
            {
                _transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                if (_staticContent)
                {
                    _staticContent.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                }
            }
            else
            {
                _transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                if (_staticContent)
                {
                    _staticContent.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                }
            }
        }

        private void Awake()
        {
            _transform = transform;
        }

        private void Start()
        {
            _target = GameConfig.Initialize().GetCharacter();
        }

        private void OnAnimatorMove()
        {
            Rotate();
        }
    }
}