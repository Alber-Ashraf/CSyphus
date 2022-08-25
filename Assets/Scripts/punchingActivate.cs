using UnityEngine;

public class punchingActivate : MonoBehaviour
{
    [SerializeField] GameObject Punching;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Punching.SetActive(true);
        }
    }
}
