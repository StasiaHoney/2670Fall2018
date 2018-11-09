using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Object Item;
    public Button[] levelButtons;
    public int LevelReached;
    public LevelList Unfinished;
    public LevelList Finished;
    
    void Start()
    {
        
        for (int i = 0; i < levelButtons.Length; i++)
        {
            levelButtons[i].interactable = false;
        }
    }

    public void LevelSelect()
    {
        for (int i = 0; i < Unfinished.ObjectList.Count; i++)
        {
            
        }
    }
}
	
