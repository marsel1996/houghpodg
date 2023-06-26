using Assets.Scripts.Enemy;
using UnityEngine;

namespace Assets.Scripts.Common.Factory
{
    public class EnemyPrefabs : Unit
    {
        [SerializeField] private RunningEnemy _runningEnemy;
        [SerializeField] private ShootingEnemy _shootingEnemy;
        [SerializeField] private RunningEnemy _bossEnemy;

        private static EnemyPrefabs _instance;
        public static EnemyPrefabs Initialize()
        {
            return _instance;
        }

        public RunningEnemy RunningEnemy => _runningEnemy;
        public ShootingEnemy ShootingEnemy => _shootingEnemy;
        public RunningEnemy BossEnemy => _bossEnemy;

        private void Awake()
        {
            if (_instance) return;

            _instance = this;
        }
    }
}