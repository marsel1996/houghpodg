using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Common;

namespace Assets.Scripts.Spawn
{
    public class StartSpawn : Unit
    {
        [SerializeField] private List<Spawner> _spawners;

        private void Start()
        {
            _spawners.ForEach(x => x.Spawn());
        }
    }
}