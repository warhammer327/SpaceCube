using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    // Start is called before the first frame update

    public Text score;
    public Transform playerPosition;
    // Update is called once per frame
    void Update()
    {
       score.text = (150-playerPosition.position.x).ToString("0");
    
    }
}
