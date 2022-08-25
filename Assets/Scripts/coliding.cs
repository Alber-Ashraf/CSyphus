using UnityEngine;

public class coliding : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacles")
        {
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
