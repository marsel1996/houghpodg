using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.MainMeny
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