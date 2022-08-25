using UnityEngine;

public class Force2 : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float autoForce = 1200f;

    private void Start()
    {
        rb.AddForce(0, 0, autoForce);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Left_Force2")
        {
            rb.AddForce(0, 0, autoForce);
        }
        else if (collisionInfo.collider.tag == "Right_Force2")
        {
            rb.AddForce(0, 0, -autoForce);
        }
    }
}
