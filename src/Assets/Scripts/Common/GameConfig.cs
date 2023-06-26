using Assets.Scripts.Meny;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public class GameConfig : Unit
    {
        [SerializeField] private List<Character.Character> _characters;
        [SerializeField] private Pause _pause; 
        [SerializeField] private DeadPanel _deadPanel;
        [SerializeField] private VictoryPanel _victoryPanel;

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
            _deadPanel.gameObject.SetActive(true);
        }

        public void Finish()
        {
            _victoryPanel.gameObject.SetActive(true);
        }

        private void Awake()
        {
            if (_instance) return;

            _instance = this;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                _pause.gameObject.SetActive(!_pause.gameObject.activeSelf);
            }
        }
    }
}