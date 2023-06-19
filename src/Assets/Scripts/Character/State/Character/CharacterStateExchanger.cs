using UnityEngine;

namespace Assets.Scripts.Character.State.Character
{
    public class CharacterStateExchanger : MonoBehaviour
    {
        [SerializeField] private Enemy.RunningEnemy _enemy;
        [SerializeField] private Animator _enemyAnimator;
        private CharacterBaseState _currentState;

        public Enemy.RunningEnemy Enemy => _enemy;
        public Animator EnemyAnimator => _enemyAnimator;
        public CharacterBaseState CurrentState => _currentState;

        public void SetState(CharacterBaseState stateType)
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
                case CharacterStateType.Run: return new RunningEnemyRunState();
                case CharacterStateType.Die: return new RunningEnemyDieState();
                case CharacterStateType.Idle: 
                default: 
                    return new RunningEnemyIdleState();
            }
        }
    }
}