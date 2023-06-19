using UnityEngine;

namespace Assets.Scripts.Character
{
    public class CharacterRotationChanger : MonoBehaviour
    {
        [SerializeField] private Transform _character;

        private void Update()
        {
            if (Input.GetButton("Horizontal"))
            {
                Rotate();
            }
        }

        public void Rotate()
        {
            var direction = Input.GetAxis("Horizontal");

            if (direction < 0)
            {
                _character.eulerAngles = new Vector3(0, 180, 0);
            } else
            {
                _character.eulerAngles = new Vector3(0, 0, 0);
            }
        }
    }
}