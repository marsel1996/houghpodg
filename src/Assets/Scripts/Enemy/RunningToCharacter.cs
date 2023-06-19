using UnityEngine;

namespace Assets.Scripts.Enemy
{
    public class RunningToCharacter : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private float _speed;
        private Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }

        private void FixedUpdate()
        {
            var targetPosition = _target.position;
            var currentPosition = _transform.position;

            if (Vector3.Distance(currentPosition, targetPosition) > .1f)
            {
                Vector3 directionOfTravel = targetPosition - currentPosition;
                //now normalize the direction, since we only want the direction information
                directionOfTravel.Normalize();
                //scale the movement on each axis by the directionOfTravel vector components

                //_transform.Translate(new Vector3(directionOfTravel.x * _speed * Time.deltaTime, 0, 0));
                var force = new Vector2(directionOfTravel.x * _speed * Time.deltaTime, 0);
                //_rb.AddForce(force, ForceMode2D.Impulse);
            }
        }
    }
}