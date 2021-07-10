using UnityEngine;
using UnityEngine.UI;

public class CellItem : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private ModeInteractionWithItem _modeInteraction;
    private ParametersItem _item;
    
    
    public void SetIconAndItem(ParametersItem item)
    {
        _icon.sprite = item.Sprite;
        _item = item;
    }

    public void Input()
    {
        print("Input cell");
        if (ModeInteractionWithItem.IsActiveMode && _item != null)
        {
            var result = _modeInteraction.CheckItemInteractionAndItemPlayerInventory(_item);
            if (result)
            {
                print("Происходит действие между предметами");
            }
        }
        else
        {
            // Использование предмета без 
        }
    }
    
    public void DeleteIcon()
    {
        _icon.sprite = null;
    }
    
}
