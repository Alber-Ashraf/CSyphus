using UnityEngine;

public class cameraController : MonoBehaviour
{
    
    [SerializeField] private float mouseSensitivity = 1;
    [SerializeField] private GameObject target;

    private Transform parent;
    void Start()
    {
        parent = transform.parent;
        Cursor.lockState = CursorLockMode.Locked;
        transform.LookAt(target.transform);
    }

    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        parent.Rotate(Vector3.up, mouseX);
    }

}
