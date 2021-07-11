using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    #region Actions

    public static Action<ParametersItem> EventChooseItem;

    public static Action EventSelectFlashlight;

    #endregion

    #region Public methods

    public static void CallEventChooseItem(ParametersItem item)
    {
        EventChooseItem?.Invoke(item);
    }

    public static void CallEventSelectFlashlight()
    {
        EventSelectFlashlight?.Invoke();
    }

    #endregion


}
