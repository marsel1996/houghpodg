namespace Assets.Scripts.Character.State.Character
{
    public class CharacterDieState : CharacterBaseState
    {
        public override void Enter(CharacterStateExchanger exchanger)
        {
            var character = exchanger.Character;
            var animator = exchanger.Animator;

            character.DestroyScripts();

            animator.SetInteger("state", (int)CharacterStateType.Die);
        }

        public override void Exit(CharacterStateExchanger exchanger)
        {
        }
    }
}