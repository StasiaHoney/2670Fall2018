using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Object", menuName = "Store/Objects")]
public class PurchaseableObjects : ScriptableObject
{
	public List<PurchasableObject> ObjectList;
}
