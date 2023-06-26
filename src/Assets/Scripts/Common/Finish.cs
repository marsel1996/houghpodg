using Assets.Scripts.Character;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public class Finish : MonoBehaviour
    {
        [SerializeField] private GameConfig _gameConfig;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var unit = collision.GetComponent<Unit>();
            if (unit && unit is CharacterBody)
            {
                _gameConfig.Finish();
            }
        }
    }
}