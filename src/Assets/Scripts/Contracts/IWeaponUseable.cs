namespace Assets.Scripts.Contracts
{
    public interface IWeaponUseable
    {
        public Weapon Weapon { get; }

        public void SetWeapon(Weapon weapon);
    }
}
