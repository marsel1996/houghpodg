using UnityEngine;

namespace Assets.Scripts.Common.Factory
{
    public class CharacterHolderPrefabs : Unit
    {
        [SerializeField] private Contracts.Holder _withAutomat;
        [SerializeField] private Contracts.Holder _withPistol;
        [SerializeField] private Contracts.Holder _withoutAnything;

        private static CharacterHolderPrefabs _instance;
        public static CharacterHolderPrefabs Initialize()
        {
            return _instance;
        }

        public Contracts.Holder WithAutomatHolder => _withAutomat;
        public Contracts.Holder WithPistolHolder => _withPistol;
        public Contracts.Holder EmptyHolder => _withoutAnything;

        private void Awake()
        {
            if (_instance) return;

            _instance = this;
        }
    }
}