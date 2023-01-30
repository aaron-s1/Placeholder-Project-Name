using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHead : MonoBehaviour
{
    [SerializeField] GameObject head;
    [SerializeField] float rotateSpeed;

    void FixedUpdate()
    {
        head.transform.Rotate(Vector3.back * Time.deltaTime * rotateSpeed);
    }
}
