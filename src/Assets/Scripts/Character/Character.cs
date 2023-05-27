using UnityEngine;

namespace Assets.Scripts.Character
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private Transform _self;
        [SerializeField] private Transform _holderPoint;

        public Transform Transform => _self;
        public Transform HolderPoint => _holderPoint;
    }
}