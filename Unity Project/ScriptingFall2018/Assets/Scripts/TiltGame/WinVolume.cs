using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinVolume : MonoBehaviour
{

	public GameObject WinUI;
	
	private void Awake()
	{
		WinUI.SetActive(false);
	}

	private void OnTriggerEnter(Collider other)
	{
		WinUI.SetActive(true);
	}
}
