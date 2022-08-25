using UnityEngine;

public class playerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            FindObjectOfType<gameManager>().EndGame();
            Destroy(this.gameObject);
        }
    }
}
