using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

	public StringData NextLevel;
	
	public void onClick()
	{
		SceneManager.LoadScene(NextLevel.Value);
	}
}
