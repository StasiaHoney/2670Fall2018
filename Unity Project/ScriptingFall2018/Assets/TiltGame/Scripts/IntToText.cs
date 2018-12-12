using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntToText : MonoBehaviour
{

	public IntData Integer;
	public Text Label;

	private void Update()
	{
		Label.text = Integer.Value.ToString();
	}
}
