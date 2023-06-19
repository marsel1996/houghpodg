using UnityEngine;

namespace Assets.Scripts.Character.State.Character
{
    public class CharacterStateExchanger : MonoBehaviour
    {
        [SerializeField] private Scripts.Character.Character _character;
        [SerializeField] private Animator _animator;
        private CharacterBaseState _currentState;

        public Scripts.Character.Character Character => _character;
        public Animator Animator => _animator;
        public CharacterBaseState CurrentState => _currentState;

        public void SetState(CharacterStateType stateType)
        {
            var state = GetStateByType(stateType);
            if (_currentState != null)
            {
                _currentState.Exit(this);
            }
            _currentState = state;
            _currentState.Enter(this);
        }

        private CharacterBaseState GetStateByType(CharacterStateType type)
        {
            switch(type)
            {
                case CharacterStateType.Run: return new CharacterRunState();
                case CharacterStateType.Die: return new CharacterDieState();
                case CharacterStateType.Idle: 
                default: 
                    return new CharacterIdleState();
            }
        }
    }
}