using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Store/StoreV2")]
public class StoreV2 : ScriptableObject
{

	public PurchasableObject Item;
	public List<Object> Purchased;
	public int ItemValue;
	public IntData Cash;

	public void Purchase()
	{
		if (Cash.Value >= ItemValue)
		{
			Purchased.Add(Item);
			Cash.Value -= ItemValue;
		}
	}

	public void AddObjectToGame()
	{
		if (Purchased.Contains(Item))
		{
			Instantiate(Purchased[0]);
			Purchased.RemoveAt(0);
		}
	}
}
