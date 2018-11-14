using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Button[] LevelButtons;
    public IntData LevelReached;

    private void Start()
    {
        for (int i = 0; i < LevelButtons.Length; i++)
        {
            if (i + 1 > LevelReached.Value)
            {
                LevelButtons[i].interactable = false;
            }
            
        }
    }
}
	
