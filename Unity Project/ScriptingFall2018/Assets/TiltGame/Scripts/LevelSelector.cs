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
    public ObjectLists Unfinished;
    public ObjectLists Finished;
    
    /*void Start()
    {
        
        for (int i = 0; i < levelButtons.Length; i++)
        {
            levelButtons[i].interactable = false;
        }
    }*/

    public void LevelSelect(ObjectItem obj)
    {
        for (int i = 0; i < Unfinished.ObjectList.Count; i++)
        {
            ObjectItem unfinishedLevel = Unfinished.ObjectList[i];
            Finished.ObjectList.Add(obj);
            Unfinished.ObjectList.Remove(unfinishedLevel);

        }
    }
}
	
