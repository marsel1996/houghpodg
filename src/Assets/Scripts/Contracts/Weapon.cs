using UnityEngine;

namespace Assets.Scripts.Contracts
{
    public abstract class Weapon : MonoBehaviour
    {
        public Transform Carrier { get; set; }

        public abstract void Attack(MonoBehaviour owner);
    }
}