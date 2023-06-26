using Assets.Scripts.Character.State.Character;
using Assets.Scripts.Common;
using Assets.Scripts.Contracts;
using UnityEngine;

namespace Assets.Scripts.Character
{
    public class CharacterMover : Unit, IMovable
    {
        private const string horizontalButtonName = "Horizontal";

        [SerializeField] private Transform _character;
        [SerializeField] private float _speed = 4f;
        [SerializeField] private CharacterStateExchanger _stateExchanger;

        private void Update()
        {
            if (Input.GetButtonUp(horizontalButtonName))
            {
                _stateExchanger.SetState(CharacterStateType.Idle);
            }
            if (Input.GetButton(horizontalButtonName))
            {
                if (_stateExchanger.CurrentState is not CharacterRunState)
                {
                    _stateExchanger.SetState(CharacterStateType.Run);
                }
                Move();
            }
        }

        public void Move()
        {
            _character.Translate(Vector3.right * _speed * Time.deltaTime);
        }
    }
}