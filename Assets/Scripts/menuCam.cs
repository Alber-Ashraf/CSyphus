using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuCam : MonoBehaviour
{
    public GameObject plate;

    private Vector3 offset;

    [SerializeField] private float rotateSpeed = 0;
    void Start()
    {
        offset = transform.position - plate.transform.position;
        transform.LookAt(offset);
    }
    void LateUpdate()
    {
        transform.RotateAround(plate.transform.position, Vector3.up, rotateSpeed * Time.deltaTime);

    }
}
