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
            if (Input.GetButton("Horizontal"))
            {
                Move();
            }
        }

        public void Move()
        {
            _character.Translate(Vector3.right * _speed * Time.deltaTime);
        }
    }
}