using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void GoToStart()
    {
        SceneManager.LoadScene("Start");
    }
    public void NowQuit()
    {
        Application.Quit();
    }
}
