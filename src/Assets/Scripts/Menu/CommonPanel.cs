using UnityEngine;

namespace Assets.Scripts.Meny
{
    public abstract class CommonPanel : MonoBehaviour
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