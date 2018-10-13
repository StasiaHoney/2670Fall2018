using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathVolume : MonoBehaviour
{
	public MovePattern Control;
	public GameObject GameoverUI;
	
	private void Awake()
	{
		GameoverUI.SetActive(false);
	}

	private void OnTriggerEnter(Collider other)
	{
		GameoverUI.SetActive(true);
	}
}
