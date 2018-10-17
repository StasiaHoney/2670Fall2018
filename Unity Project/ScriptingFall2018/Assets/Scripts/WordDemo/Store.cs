using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Store", menuName = "Store/StoreFront")]
public class Store : ScriptableObject
{

    public Objects Available;
    public Objects Purchased;
    public IntData Cash;
    public int TotalValue = 500;

    public UnityEvent MadePurchase;
    
    public void MakePurchase(PurchasableObject obj)
    {
        for (var i = 0; i < Available.ObjectList.Count; i++)
        {
            PurchasableObject availableObject = Available.ObjectList[i] as PurchasableObject;
            if (availableObject == obj && Cash.Value >= availableObject.Value)
            {
                Cash.Value -= availableObject.Value;
                Purchased.ObjectList.Add(obj);
                Available.ObjectList.Remove(availableObject);
                MadePurchase.Invoke();
            }
        }
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
    }
    
}
