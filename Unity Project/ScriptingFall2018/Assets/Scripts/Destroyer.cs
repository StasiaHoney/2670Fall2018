﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

	public float HoldTime = 2;
	public bool UseTrigger = true;

	IEnumerator Start()
	{
		yield return new WaitForSeconds(HoldTime);
	}

	public void DestroyObj()
	{
		Destroy(gameObject);
	}
	
	
}
