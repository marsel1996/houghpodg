namespace Assets.Scripts.Character.State.Character
{
    public class CharacterDieState : CharacterBaseState
    {
        public override void Enter(CharacterStateExchanger exchanger)
        {
            var animator = exchanger.Animator;

            animator.SetInteger("state", (int)CharacterStateType.Die);
        }

        public override void Exit(CharacterStateExchanger exchanger)
        {
        }
    }
}