using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    #region Actions

    public static Action<ParametersItem> EventChooseItem;

    #endregion

    #region Public methods

    public static void CallEventChooseItem(ParametersItem item)
    {
        EventChooseItem?.Invoke(item);
    }

    #endregion


}
