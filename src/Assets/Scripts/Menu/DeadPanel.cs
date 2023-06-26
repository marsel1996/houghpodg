using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Meny
{
    public class DeadPanel : CommonPanel
    {
        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}