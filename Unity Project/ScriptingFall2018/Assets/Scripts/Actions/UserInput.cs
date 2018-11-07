using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{

	public ActionObject Action;
	public IntData i;
	
	private void OnMouseDown()
	{
		Action.Raise();
	}
}
