using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (fileName = "NewWeapon", menuName = "Weapon")]
public class WeaponScriptableObject : ScriptableObject
{

	public GameObject weapon;

	public virtual GameObject Weapon
	{
		get { return weapon; }
	}

}
