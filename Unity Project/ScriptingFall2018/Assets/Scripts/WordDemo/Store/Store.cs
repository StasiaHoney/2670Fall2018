using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Store", menuName = "Store/StoreFront")]
public class Store : ScriptableObject
{

    public PurchaseableObjects Available;
    public PurchaseableObjects Purchased;
    public GameObject Canvas;
    public GameObject Button;
    public IntData Cash;
    public int TotalValue = 500;

    public UnityEvent MadePurchase;
    
    public void MakePurchase(PurchasableObject obj)
    {
        for (var i = 0; i < Available.ObjectList.Count; i++)
        {
            PurchasableObject availableObject = Available.ObjectList[i];
            if (availableObject == obj && Cash.Value >= availableObject.Value)
            {
                Cash.Value -= availableObject.Value;
                Purchased.ObjectList.Add(obj);
                Available.ObjectList.Remove(availableObject);
                MadePurchase.Invoke();
            }
        }
    }

    public void BuildUI()
    {    var newCanvas = Instantiate(Canvas);
        foreach (var obj in Available.ObjectList)
        {
            
            var newButton = Instantiate(Button, newCanvas.GetComponentInChildren<VerticalLayoutGroup>().transform);
            var ButtonComponent = newButton.GetComponent<Button>();
            ButtonComponent.onClick.AddListener(() => { MakePurchase(Available.ObjectList[0]); });
            var label = newButton.GetComponentInChildren<Text>();
            label.text = Available.ObjectList[0].name;
        }
    }

    private void PurchaseButton()
    {
        
    }

    public void PurchaseAll()
    {
        if (Cash.Value >= TotalValue)
        {    Cash.Value -= TotalValue;
            for (var i = 0; i < Available.ObjectList.Count; i++)
            {
                var item = Available.ObjectList[0];
                
                Purchased.ObjectList.Add(item);
                Available.ObjectList.RemoveAt(0);
            }
        }
        Available.ObjectList.Clear();
    }

    private void OnEnable()
    {
        throw new System.NotImplementedException();
    }
}
