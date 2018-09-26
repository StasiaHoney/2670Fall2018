using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class WeaponSwitch : MonoBehaviour
{
    public int currentWeapon;
    public Transform [] weapons;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            changeWeapon(1);
        }
    }

    public void changeWeapon(int num)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(i == num)
                
                weapons[i].gameObject.SetActive(true);
            else
            {
                weapons[i].gameObject.SetActive(false);
            }
        }
    }
}
