using UnityEngine;
using Assets.Scripts.Common;

namespace Assets.Scripts.Character
{
    public class CharacterBody : Unit
    {
        [SerializeField] private Character _character;

        public Character Character => _character;
    }
}