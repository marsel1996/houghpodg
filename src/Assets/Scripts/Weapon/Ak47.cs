using Assets.Scripts.Contracts;

namespace Assets.Scripts.Weapon
{
    public class Ak47 : AutomaticGun
    {
        public override void Attack()
        {
            print("pif pif");
        }
    }
}