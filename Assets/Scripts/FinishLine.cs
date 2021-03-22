using UnityEngine;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().LevelCompeted();
    }
}
