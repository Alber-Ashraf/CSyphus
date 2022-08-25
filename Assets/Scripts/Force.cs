using UnityEngine;

public class Force : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float autoForce = 1200f;

    private void Start()
    {
        rb.AddForce(autoForce, 0, 0);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Left_Force")
        {
            rb.AddForce(autoForce, 0, 0);
        }
        else if (collisionInfo.collider.tag == "Right_Force")
        {
            rb.AddForce(-autoForce, 0, 0);
        }
    }
}
