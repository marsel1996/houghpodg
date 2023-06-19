using UnityEngine;

namespace Assets.Scripts.Common
{
    public class RotationByTargetPosition : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        private Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }
        private void OnAnimatorMove()
        {
            if (_target.position.x >= _transform.position.x)
            {
                _transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            }
            else
            {
                _transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
            }
        }
    }
}