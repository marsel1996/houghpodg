using Assets.Scripts.Common;
using Assets.Scripts.Enemy.States.RunningEnemy;
using Assets.Scripts.Weapon.Enemy;
using UnityEngine;

namespace Assets.Scripts.Enemy
{
    public class RunningEnemy : Contracts.Enemy
    {
        [SerializeField] private RunningToCharacter _runScript;
        [SerializeField] private RotationByTargetPosition _rotateScript;
        [SerializeField] private RunningEnemyStateExchanger _stateExchanger;
        [SerializeField] private BoxCollider2D _body;
        [SerializeField] private EnemyHealth _health;
        [SerializeField] private EnemyDamagable _damagable;
        [SerializeField] private EnemyBareHands _weapon; 

        public RunningToCharacter RunScript => _runScript;
        public RotationByTargetPosition RotateScript => _rotateScript;

        public override void Die()
        {
            _stateExchanger.SetState(RunningEnemyStateType.Die);
            Invoke(nameof(Death), 2f);
        }
        
        public void DestroyScripts()
        {
            _weapon?.Remove();
            _damagable.Remove();
            _health.Remove();
            _rotateScript.Remove();
            _runScript.Remove();
            _stateExchanger.Remove();
        }

        public override void DestroyBody()
        {
            Destroy(_body);
        }

        private void Death()
        {
            Remove(true);
        }

        private void Start()
        {
            _stateExchanger.SetState(RunningEnemyStateType.Run);
        }
    }
}