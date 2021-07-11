using UnityEngine;
using UnityEngine.UI;

public class CellItem : MonoBehaviour
{
    [SerializeField] private Image _icon;
    private ParametersItem _item;
    
    
    public void SetIconAndItem(ParametersItem item)
    {
        _icon.sprite = item.Sprite;
        _item = item;
    }

    public void Input()
    {
    }
    
    public void DeleteIcon()
    {
        _icon.sprite = null;
    }
    
}
