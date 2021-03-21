using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement player;
    void OnCollisionEnter(Collision collisioninfo) {
        
        if(collisioninfo.collider.tag=="Obstacle")
        {
            player.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
