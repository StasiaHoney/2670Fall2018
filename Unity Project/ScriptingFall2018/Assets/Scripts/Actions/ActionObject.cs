using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu (fileName = "GameAction", menuName = "Actions/GameActions")]
public class ActionObject : ScriptableObject
{
    public UnityAction Raise;
}
