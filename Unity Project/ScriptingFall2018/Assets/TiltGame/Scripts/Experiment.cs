using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experiment : MonoBehaviour
{
    private Camera cam;
    private bool CanRotate = false;
    private Vector3 OffsetPosition;

    private void Start()
    {
        cam = Camera.main;
    }

    private IEnumerator OnMouseDown()
    {
        CanRotate = true;
        
        yield return new WaitForFixedUpdate();
        while (CanRotate)
        {
            
        }
        
    }

    private void OnMouseUp()
    {
        CanRotate = false;
    }
}

