using UnityEngine;

public class punchingDeActivate : MonoBehaviour
{
    [SerializeField] GameObject malePunching;
    [SerializeField] GameObject maleFist;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            malePunching.SetActive(false);
            maleFist.SetActive(false);
        }
    }
}
