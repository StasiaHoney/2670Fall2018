﻿using UnityEngine;

[CreateAssetMenu(fileName = "Purchase", menuName = "Store/Purchasable")]
public class PurchasableObject : ScriptableObject
{

	public Object Item;
	public int Value;
	public bool Perpetual;
	public bool Instantiatable;

	public void CreatItem()
	{
		if (Instantiatable && Item is GameObject)
		{
			Instantiate(Item);
			
		}
	}

}
