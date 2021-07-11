using UnityEngine;
using UnityEngine.UI;

public class CellItem : MonoBehaviour
{
    [SerializeField] private Image _icon;
    private ParametersItem _parameters;

    private Text _name;
    private Text _description;
    

    public void InitTextNameAndDescription(Text name, Text description)
    {
        _name = name;
        _description = description;
    }

    public void SetIconAndItem(ParametersItem parameters)
    {
        _icon.sprite = parameters.Sprite;
        _parameters = parameters;
    }
    
    public void Input()
    {
        if (_parameters != null)
        {
            SetNameAndDescription();
            EventManager.CallEventChooseItem(_parameters);
        }
    }
    
    private void SetNameAndDescription()
    {
        _name.text = _parameters.Name;
        _description.text = _parameters.Description;
    }

    
    public void DeleteIcon()
    {
        _icon.sprite = null;
    }
    
}
