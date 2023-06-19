using UnityEngine;

namespace Assets.Scripts.Contracts
{
    public abstract class CharacterShooter : MonoBehaviour
    {
        [SerializeField] private Character.Character _character;

        public Weapon Weapon { get; set; }
        public Character.Character Character => _character;
    }
}