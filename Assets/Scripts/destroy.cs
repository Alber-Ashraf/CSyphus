using UnityEngine;

public class destroy : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Obstacles Destroyer")
        {
            Destroy(this.gameObject);
        }
    }
}
