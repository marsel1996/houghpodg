using UnityEngine;

namespace Assets.Scripts.Meny
{
    public class Pause : MonoBehaviour
    {
        private float preTimeScale = 0;

        private void OnEnable()
        {
            preTimeScale = Time.timeScale;
            Time.timeScale = 0;
        }

        private void OnDisable()
        {
            Time.timeScale = preTimeScale;
        }
    }
}