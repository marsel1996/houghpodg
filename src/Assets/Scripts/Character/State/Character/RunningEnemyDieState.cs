namespace Assets.Scripts.Enemy.States.RunningEnemy
{
    public class RunningEnemyDieState : RunningEnemyBaseState
    {
        public override void Enter(RunningEnemyStateExchanger exchanger)
        {
            var animator = exchanger.EnemyAnimator;
            var enemy = exchanger.Enemy;

            animator.SetInteger("state", (int)RunningEnemyStateType.Die);
        }

        public override void Exit(RunningEnemyStateExchanger exchanger)
        {
        }
    }
}