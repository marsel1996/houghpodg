using UnityEngine;

namespace Assets.Scripts.Contracts
{
    public abstract class CharacterShooter : MonoBehaviour
    {
        public Weapon Weapon { get; set; }
    }
}