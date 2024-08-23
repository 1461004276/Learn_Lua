using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class LuaLifeCircle : MonoBehaviour
{
    public UnityAction awakeAction;
    public UnityAction startAction;
    public UnityAction updateAction;
    public enum ELifeType 
    { 
        Awake, 
        Start, 
        Update 
    }

    public void Test(UnityAction a)
    {

    }

    public void AddOrRemoveAction(UnityAction _unityAction, ELifeType _lifeType, bool canAdd = true)
    {
        switch (_lifeType)
        {
            case ELifeType.Awake:
                if (canAdd)
                {
                    awakeAction += _unityAction;
                }
                else
                {
                    awakeAction -= _unityAction;
                }
                break;
            case ELifeType.Start:
                if (canAdd) { startAction += _unityAction; } else { startAction -= _unityAction; }
                break;
            case ELifeType.Update:
                if (canAdd) { updateAction += _unityAction; }
                else { updateAction -= _unityAction; }
                break;
        }
    }
}