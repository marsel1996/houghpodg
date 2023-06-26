using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Common;

namespace Assets.Scripts.Spawn
{
    public class TriggerSpawn : Unit
    {
        [SerializeField] private List<Spawner> _spawners;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            collision.TryGetComponent<Character.CharacterBody>(out var characterBody);
            if (characterBody != null)
            {
                _spawners.ForEach(x => x.Spawn());
            }
            Remove(gameObject);
        }
    }
}