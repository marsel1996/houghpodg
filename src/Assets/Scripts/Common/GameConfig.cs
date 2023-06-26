using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public class GameConfig : Unit
    {
        [SerializeField] private List<Character.Character> _characters;

        private static GameConfig _instance;

        public static GameConfig Initialize()
        {
            return _instance;
        }

        public Character.Character GetCharacter()
        {
            return _characters.Count > 0
                ? _characters[0]
                : null;
        }

        public void End()
        {
            var enemies = FindObjectsOfType<Contracts.Enemy>();
            foreach(var enemy in enemies)
            {
                enemy.Die();
            }
        }

        private void Awake()
        {
            if (_instance) return;

            _instance = this;
        }
    }
}