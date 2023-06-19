namespace Assets.Scripts.Enemy.States.RunningEnemy
{
    public class CharacterIdleState : RunningEnemyBaseState
    {
        public override void Enter(RunningEnemyStateExchanger exchanger)
        {
            var animator = exchanger.EnemyAnimator;
            var enemy = exchanger.Enemy;

            animator.SetInteger("state", (int)RunningEnemyStateType.Idle);

            enemy.RotateScript.enabled = true;
            enemy.RunScript.enabled = false;
        }

        public override void Exit(RunningEnemyStateExchanger exchanger)
        {
        }
    }
}