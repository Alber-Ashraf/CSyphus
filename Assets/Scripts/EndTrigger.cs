using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag =="Player")
        {
            SceneManager.LoadScene("Victory");
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
