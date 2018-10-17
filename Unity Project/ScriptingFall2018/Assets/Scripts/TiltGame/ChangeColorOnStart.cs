using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeColorOnStart : MonoBehaviour
{

	public ChangeColor Color;
	public UnityEvent ChangeColorData;

	private void Start(ColorData color)
	{
		Call(color);
	}

	public void Call(ColorData color)
	{
		if (color == Color)
		{
			ChangeColorData.Invoke();
		}
	}
}
