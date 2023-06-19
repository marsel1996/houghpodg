namespace Assets.Scripts.Character.State.Character
{
    public abstract class CharacterBaseState
    {
        public abstract void Enter(CharacterStateExchanger exchanger);
        public abstract void Exit(CharacterStateExchanger exchanger);
    }
}