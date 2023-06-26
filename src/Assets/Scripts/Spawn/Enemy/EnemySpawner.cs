using Assets.Scripts.Common.Factory;
using UnityEngine;

namespace Assets.Scripts.Spawn.Enemy
{
    public class EnemySpawner : Spawner
    {
        [SerializeField] private EnemySpawnerType _type;
        
        private Transform _transform;

        public override void Spawn()
        {
            var prefab = GetEnemyByType(_type);
            Instantiate(prefab, _transform.position, Quaternion.identity);
            Remove(gameObject);
        }

        private void Awake()
        {
            _transform = transform;
        }

        private Contracts.Enemy GetEnemyByType(EnemySpawnerType type)
        {
            switch(type)
            {
                case EnemySpawnerType.Shooting:
                    return EnemyPrefabs.Initialize().ShootingEnemy;
                case EnemySpawnerType.Boss:
                    return EnemyPrefabs.Initialize().BossEnemy; 
                case EnemySpawnerType.Running:
                default:
                    return EnemyPrefabs.Initialize().RunningEnemy;
            }
        }
    }
}