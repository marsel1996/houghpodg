using UnityEngine;

namespace Assets.Scripts.Common
{
    public class HolderPrefabs : MonoBehaviour
    {
        [SerializeField] private Contracts.Holder _withAutomat;
        [SerializeField] private Contracts.Holder _withPistol;
        [SerializeField] private Contracts.Holder _withoutAnything;

        private static HolderPrefabs _instance;
        public static HolderPrefabs Initialize()
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