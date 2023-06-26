using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Meny
{
    public class MainMenu : MonoBehaviour
    {
        public void Run()
        {
            SceneManager.LoadScene("MainScene");
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}