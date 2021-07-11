using UnityEngine;
using UnityEngine.UI;

public class CellItem : MonoBehaviour
{
    [SerializeField] private Image _icon;
    private ParametersItem _parameters;
    
    
    public void SetIconAndItem(ParametersItem parameters)
    {
        _icon.sprite = parameters.Sprite;
        _parameters = parameters;
    }

    public void Input()
    {
        if (_parameters != null)
        {
            EventManager.CallEventChooseItem(_parameters);
        }
    }
    
    public void DeleteIcon()
    {
        _icon.sprite = null;
    }
    
}
