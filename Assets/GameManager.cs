using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool endGame = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void LevelCompeted()
    {
        Debug.Log("level sesh");
        completeLevelUI.SetActive(true);
        Invoke("Restart",restartDelay); // remove this once you have designed next level
    }
    public void EndGame()
    {
        if(!endGame)
        {
            //Debug.Log("Dhaan khete shagotom madarchor"); 
            endGame = true;
            //Restart();
        restartLevelUI.SetActive(true);
            Invoke("Restart",restartDelay);
        }
    }
    public GameObject restartLevelUI;
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
