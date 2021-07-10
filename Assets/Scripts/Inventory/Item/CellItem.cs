using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellItem : MonoBehaviour
{
    [SerializeField] private Image _icon;

    public void SetIcon(Sprite icon)
    {
        _icon.sprite = icon;
    }

    public void DeleteIcon()
    {
        _icon.sprite = null;
    }
    
}
