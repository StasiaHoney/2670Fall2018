using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipLevel : MonoBehaviour
{

	public BoolData LevelToSkip;
	
	public void OnClick()
	{
		LevelToSkip.Value = true;
	}
}
