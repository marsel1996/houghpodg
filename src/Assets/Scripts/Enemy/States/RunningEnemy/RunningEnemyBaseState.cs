using Assets.Scripts.Common;

namespace Assets.Scripts.Enemy.States.RunningEnemy
{
    public abstract class RunningEnemyBaseState
    {
        public abstract void Enter(RunningEnemyStateExchanger exchanger);
        public abstract void Exit(RunningEnemyStateExchanger exchanger);
    }
}