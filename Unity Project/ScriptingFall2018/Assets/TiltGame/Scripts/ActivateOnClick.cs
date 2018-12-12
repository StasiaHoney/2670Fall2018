using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnClick : MonoBehaviour
{

	public GameObject Panel;
	
	private void Awake()
	{
		Panel.SetActive(false);
	}

	public void OnClick()
	{
		Panel.SetActive(true);
	}

	public void AfterPurchase()
	{
		Panel.SetActive(false);
	}
}
