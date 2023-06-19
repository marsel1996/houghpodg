using Assets.Scripts.Common;
using Assets.Scripts.Enemy.States.RunningEnemy;
using UnityEngine;

namespace Assets.Scripts.Enemy
{
    public class RunningEnemy : Contracts.Enemy
    {
        [SerializeField] private RunningToCharacter _runScript;
        [SerializeField] private RotationByTargetPosition _rotateScript;
        [SerializeField] private RunningEnemyStateExchanger _stateExchanger;

        public RunningToCharacter RunScript => _runScript;
        public RotationByTargetPosition RotateScript => _rotateScript;

        public override void Die()
        {
            _stateExchanger.SetState(RunningEnemyStateType.Die);
        }

        private void Start()
        {
            _stateExchanger.SetState(RunningEnemyStateType.Run);
        }
    }
}