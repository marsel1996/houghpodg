using Assets.Scripts.Common;
using Assets.Scripts.Contracts;
using UnityEngine;

namespace Assets.Scripts.Character
{
    public class CharacterDamagable : UnitDamagable
    {
        [SerializeField] private CharacterHealth _health;

        public CharacterHealth Health => _health;

        public override void Damage(IDamageVisiter visiter)
        {
            visiter.Visit(this);
        }
    }
}