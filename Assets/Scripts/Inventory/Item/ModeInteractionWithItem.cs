using UnityEngine;

public class ModeInteractionWithItem : MonoBehaviour
{
    private ParametersItem _itemWhichInteractionTakesPlace;
    private static bool _isActiveMode;
    public static bool IsActiveMode => _isActiveMode;

    private void Start()
    {
        _isActiveMode = false;
    }

    public void SetActiveModeAndItem(Item item)
    {
        _isActiveMode = true;
        _itemWhichInteractionTakesPlace = item.Parameters;
    }

    public bool CheckItemInteractionAndItemPlayerInventory(ParametersItem item)
    {
        _isActiveMode = false;
        return item.TypeActionSubject == TypeActionSubject.SelectionInventory &&
               _itemWhichInteractionTakesPlace.TypeActionSubject == TypeActionSubject.InteractionStage &&
               item.Type == _itemWhichInteractionTakesPlace.TypeInteraction;
    }
    
}