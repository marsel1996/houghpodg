using Assets.Scripts.Character.State.Character;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Character
{
    public class Character : Unit
    {
        [SerializeField] private Transform _self;
        [SerializeField] private Transform _holderPoint;
        [SerializeField] private CharacterStateExchanger _stateExchanger;
        [SerializeField] private CharacterWeaponModeExchanger _weaponMode;
        [SerializeField] private CharacterHealth _health; 
        [SerializeField] private Transform _body;

        public Transform Transform => _self;
        public Transform HolderPoint => _holderPoint;
        public Transform Body => _body;

        public void Die()
        {
            _stateExchanger.SetState(CharacterStateType.Die);
            Remove(true);
        }

        public void DestroyScripts()
        {
            _health.Remove();
            _stateExchanger.Remove();
        }

        private void Start()
        {
            _stateExchanger.SetState(CharacterStateType.Idle);
        }

        private void OnEnable()
        {
            _weaponMode.OnHolderChanged += HolderChanged;
        }

        private void OnDisable()
        {
            _weaponMode.OnHolderChanged -= HolderChanged;
        }

        private void HolderChanged(Contracts.Holder holder)
        {
            _stateExchanger.Animator.Rebind();
        }
    }
}