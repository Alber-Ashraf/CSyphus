using UnityEngine;

public class monstersKilling : MonoBehaviour
{
    [SerializeField] private float restartDelay = 4f;

    [SerializeField] GameObject monster;
    [SerializeField] GameObject killingArea;

    [SerializeField] GameObject malePunching;

    [SerializeField] GameObject maleFist;

    [SerializeField] private Animator animator;

    void OnTriggerEnter(Collider collider)  
    {
        if (collider.gameObject.tag == "Fist")
        {
            GetComponent<CapsuleCollider>().enabled = false;
            Invoke("monsterKilled", restartDelay);
            Invoke("score", restartDelay);
            Invoke("Area", restartDelay);
            Invoke("puchDeActivating", restartDelay);
            animator.SetTrigger("Dead");
        }
    }

    void puchDeActivating()
    {
        malePunching.SetActive(false);
        maleFist.SetActive(false);
    }
    void monsterKilled()
    {
        monster.SetActive(false);
    }

    void Area()
    {
        killingArea.SetActive(false);
    }
    void score()
    {
         if(!monster.activeSelf)
         FindObjectOfType<monstersScore>().monstersNum = FindObjectOfType<monstersScore>().monstersNum -1;
    }
}
