namespace Assets.Scripts.Enemy.States.RunningEnemy
{
    public class RunningEnemyRunState : RunningEnemyBaseState
    {
        public override void Enter(RunningEnemyStateExchanger exchanger)
        {
            var animator = exchanger.EnemyAnimator;
            var enemy = exchanger.Enemy;

            animator.SetInteger("state", (int)RunningEnemyStateType.Run);

            enemy.RotateScript.enabled = true;
            enemy.RunScript.enabled = true;
        }

        public override void Exit(RunningEnemyStateExchanger exchanger)
        {
            var enemy = exchanger.Enemy;

            enemy.RotateScript.enabled = false;
            enemy.RunScript.enabled = false;
        }
    }
}