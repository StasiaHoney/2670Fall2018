﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunCountdown : MonoBehaviour
{
	public float seconds = 1.0f;
	public int number = 3;
	private Text label;
	
	IEnumerator Start ()
	{
		label = GetComponent<Text>();

		int number = 3;
		
		while (number > 0)
		{
			yield return new WaitForSeconds(1);
			label.text = number.ToString();
			number--;
		}

		label.text = "";
		
		yield return new WaitForSeconds(1);
		label.text = "GO!";
	}
}
