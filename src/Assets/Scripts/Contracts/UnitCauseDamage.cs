using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Contracts
{
    public abstract class UnitCauseDamage : Unit
    {
        public float Value { get; private set; }

        public void SetValue(float value)
        {
            Value = value;
        }
    }
}