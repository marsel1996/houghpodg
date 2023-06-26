using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Meny
{
    public class VictoryPanel : CommonPanel
    {
        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}