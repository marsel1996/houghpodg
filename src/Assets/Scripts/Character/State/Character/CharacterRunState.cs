namespace Assets.Scripts.Character.State.Character
{
    public class CharacterRunState : CharacterBaseState
    {
        public override void Enter(CharacterStateExchanger exchanger)
        {
            var animator = exchanger.Animator;

            animator.SetInteger("state", (int)CharacterStateType.Run);
        }

        public override void Exit(CharacterStateExchanger exchanger)
        {
        }
    }
}