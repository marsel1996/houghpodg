using UnityEngine;
using Assets.Scripts.Common;

namespace Assets.Scripts.Enemy.States.RunningEnemy
{
    public class RunningEnemyStateExchanger : Unit
    {
        [SerializeField] private Enemy.RunningEnemy _enemy;
        [SerializeField] private Animator _enemyAnimator;
        private RunningEnemyBaseState _currentState;

        public Enemy.RunningEnemy Enemy => _enemy;
        public Animator EnemyAnimator => _enemyAnimator;
        public RunningEnemyBaseState CurrentState => _currentState;

        public void SetState(RunningEnemyStateType stateType)
        {
            var state = GetStateByType(stateType);
            if (_currentState != null)
            {
                _currentState.Exit(this);
            }
            _currentState = state;
            _currentState.Enter(this);
        }

        private RunningEnemyBaseState GetStateByType(RunningEnemyStateType type)
        {
            switch(type)
            {
                case RunningEnemyStateType.Run: return new RunningEnemyRunState();
                case RunningEnemyStateType.Die: return new RunningEnemyDieState();
                case RunningEnemyStateType.Idle: 
                default: 
                    return new CharacterIdleState();
            }
        }
    }
}