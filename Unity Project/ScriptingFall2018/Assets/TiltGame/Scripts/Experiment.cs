using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experiment : MonoBehaviour
{
float rotSpeed = 20;

void OnMouseDrag(){
    float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Rad2Deg;
    float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Rad2Deg;

    transform.RotateAround(Vector3.up, -rotX);
   transform.RotateAround(Vector3.right, rotY);
}
}

