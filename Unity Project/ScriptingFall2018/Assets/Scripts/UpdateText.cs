using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
    public ActionObject Action;
    private Text Label;
    public IntData number;
    
    private void Start()
    {
        Label = GetComponent<Text>();
        Action.Raise += RaiseHandler;
    }

    private void RaiseHandler()
    {
        Label.text += number.Value.ToString();
    }
}
