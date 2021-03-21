using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool endGame = false;
    public float restartDelay = 1f;

    public void LevelCompeted()
    {
        Debug.Log("level sesh");
    }
    public void EndGame()
    {
        if(!endGame)
        {
            //Debug.Log("Dhaan khete shagotom madarchor"); 
            endGame = true;
            //Restart();
            Invoke("Restart",restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
