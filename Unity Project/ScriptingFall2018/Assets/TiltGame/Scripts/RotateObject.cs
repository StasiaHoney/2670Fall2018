using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
	public bool CanRotate;
	private Vector3 newPosition;
	private Vector3 offsetPosition;
	private Camera cam;


	private void OnMouseDown()
	{
		CanRotate = true;
		while (CanRotate)
		{
			
		}
	}


	private void OnMouseUp()
	{
		CanRotate = false;
	}
}
