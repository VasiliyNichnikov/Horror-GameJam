using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    #region Actions

    public static Action<ParametersItem, CellItem> EventChooseItem;

    public static Action EventSelectFlashlight;

    public static Action<bool> EventChangeStateInventory;

    public static Action<TypeMonologue> EventSelectMonologueText;

    #endregion

    #region Public methods

    public static void CallChooseItem(ParametersItem parameters, CellItem cell)
    {
        EventChooseItem?.Invoke(parameters, cell);
    }

    public static void CallSelectFlashlight()
    {
        EventSelectFlashlight?.Invoke();
    }
    
    public static void CellChangeStateInventory(bool state)
    {
        EventChangeStateInventory?.Invoke(state);
    }
    
    public static void CellSelectMonologueText(TypeMonologue type)
    {
        EventSelectMonologueText?.Invoke(type);
    }

    #endregion


}
