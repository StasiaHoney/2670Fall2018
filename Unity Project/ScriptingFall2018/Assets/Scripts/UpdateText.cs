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
        OnUpdate();
    }

    private void OnUpdate()
    {
        Label.text = number.Value.ToString("C0");
    }
}
