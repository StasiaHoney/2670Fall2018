using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

	public StringData NextLevel;
	
	public void Click()
	{
		SceneManager.LoadScene(NextLevel.Value);
	}
}
