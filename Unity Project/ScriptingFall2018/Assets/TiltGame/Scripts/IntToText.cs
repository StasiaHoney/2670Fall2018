using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntToText : MonoBehaviour
{

	public IntData Integer;
	public Text Label;

	private void Start()
	{
		Label.text = Integer.Value.ToString();
	}
}
