namespace Assets.Scripts.Character.State.Character
{
    public class CharacterIdleState : CharacterBaseState
    {
        public override void Enter(CharacterStateExchanger exchanger)
        {
            var animator = exchanger.EnemyAnimator;
            var enemy = exchanger.Enemy;

            animator.SetInteger("state", (int)CharacterStateType.Idle);

            enemy.RotateScript.enabled = true;
            enemy.RunScript.enabled = false;
        }

        public override void Exit(CharacterStateExchanger exchanger)
        {
        }
    }
}