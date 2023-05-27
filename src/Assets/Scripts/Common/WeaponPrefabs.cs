using Assets.Scripts.Weapon;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public class WeaponPrefabs : MonoBehaviour
    {
        [SerializeField] private Ak47 _ak47;
        [SerializeField] private Makarov _makarov;

        private static WeaponPrefabs _instance;
        public static WeaponPrefabs Initialize()
        {
            return _instance;
        }

        public Ak47 Ak47 => _ak47;
        public Makarov Makarov => _makarov;

        private void Awake()
        {
            if (_instance) return;

            _instance = this;
        }
    }
}