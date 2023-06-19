using Assets.Scripts.Weapon.Bullet;
using UnityEngine;

namespace Assets.Scripts.Common.Factory
{
    public class BulletPrefabs : MonoBehaviour
    {
        [SerializeField] private CommonBullet _long;
        [SerializeField] private CommonBullet _short;

        private static BulletPrefabs _instance;
        public static BulletPrefabs Initialize()
        {
            return _instance;
        }

        public CommonBullet Long => _long;
        public CommonBullet Short => _short;

        private void Awake()
        {
            if (_instance) return;

            _instance = this;
        }
    }
}