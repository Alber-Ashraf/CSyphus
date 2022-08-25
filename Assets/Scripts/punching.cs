using UnityEngine;

public class punching : MonoBehaviour
{
    [SerializeField] GameObject fist;
    [SerializeField] private Animator animator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            fist.SetActive(true);
            animator.SetTrigger("Punch");
            Invoke("Fist", 0.1f);
        }
    }

    void Fist()
    {
        if (!Input.GetKeyDown(KeyCode.Mouse0))
        {
            fist.SetActive(false);
        }
    }
}
