using Assets.Scripts.Contracts;
using UnityEngine;

namespace Assets.Scripts.Character
{
    public class CharacterMover : MonoBehaviour, IMovable
    {
        [SerializeField] private Transform _character;
        [SerializeField] private float _speed = 4f;

        private void Update()
        {
            if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
            {
                Move();
            }
        }

        public void Move()
        {
            var directionX = Input.GetAxis("Horizontal");
            var directionY = Input.GetAxis("Vertical");

            var direction = Vector3.right * directionX + Vector3.up * directionY;
            _character.transform.Translate(direction * _speed * Time.deltaTime);
        }
    }
}