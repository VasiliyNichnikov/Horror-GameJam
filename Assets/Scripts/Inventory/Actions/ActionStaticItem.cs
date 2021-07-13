using System;
using UnityEngine;

public class ActionStaticItem : MonoBehaviour
{
    private StoreItems _store;
    private Item _selectedItem;
    private static bool _isActiveInteraction;
    public static bool IsActiveInteration => _isActiveInteraction;

    private void OnEnable()
    {
        EventManager.EventChooseItem += ChoiceItemAndClearCell;
    }

    private void OnDisable()
    {
        EventManager.EventChooseItem -= ChoiceItemAndClearCell;
    }

    private void Start()
    {
        _store = GetComponent<StoreItems>();
    }

    private void Update()
    {
        var isDeactivationInteraction = CheckingDeactivationInteraction();
        if (isDeactivationInteraction)
        {
            DeactivationInteractionAndCloseInventory();
        }
    }

    private bool CheckingDeactivationInteraction()
    {
        return (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Tab)) && _isActiveInteraction;
    }

    public void ActivatingInteractionAndShowInventory(Item item)
    {
        _isActiveInteraction = true;
        _selectedItem = item;
        EventManager.CellChangeStateInventory(true);
    }

    private void DeactivationInteractionAndCloseInventory()
    {
        _isActiveInteraction = false;
        _selectedItem = null;
    }

    private void ChoiceItemAndClearCell(ParametersItem parameters, CellItem cell)
    {
        if (_selectedItem == null)
        {
            throw new Exception("Предмета для взаимодействия нет");
        }

        var isPossible = CheckingPossibilityInteraction(parameters);
        if (isPossible)
        {
            print($"Взаимодействие с объектом: {_selectedItem.Parameters.Name}");
            _selectedItem.InteractionStaticAction(parameters);
            cell.ClearCell();
            _store.DeleteItem(parameters);
        }
        else
        {
            print("Данный предмет не подходит");
        }
    }

    private bool CheckingPossibilityInteraction(ParametersItem parameters)
    {
        return _selectedItem.Parameters.Type == parameters.TypeInteraction &&
               _selectedItem.Parameters.ConditionItem != parameters.ConditionItem;
    }
}