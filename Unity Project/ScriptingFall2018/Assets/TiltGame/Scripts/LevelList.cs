using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "LevelList", menuName = "Level/LevelList")]
public class LevelList : ScriptableObject {

	public List<PurchasableObject> ObjectList;
}
