namespace Assets.Scripts.Character.State.Character
{
    public class CharacterIdleState : CharacterBaseState
    {
        public override void Enter(CharacterStateExchanger exchanger)
        {
            var animator = exchanger.Animator;

            animator.SetInteger("state", (int)CharacterStateType.Idle);
        }

        public override void Exit(CharacterStateExchanger exchanger)
        {
        }
    }
}