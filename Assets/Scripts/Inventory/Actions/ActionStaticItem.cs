using System;
using UnityEngine;

public class ActionStaticItem : MonoBehaviour
{
    private Item _selectedItem;
    private static bool _isActiveInteraction;
    public static bool IsActiveInteration => _isActiveInteraction;

    private void OnEnable()
    {
        EventManager.EventChooseItem += ChoiceItem;
    }

    private void OnDisable()
    {
        EventManager.EventChooseItem -= ChoiceItem;
    }

    public void ActivatingInteraction(Item item)
    {
        _isActiveInteraction = true;
        _selectedItem = item;
    }

    private void ChoiceItem(ParametersItem parameters)
    {
        if (_selectedItem == null)
        {
            throw new Exception("Предмета для взаимодействия нет");
        }
        var isPossible = CheckingPossibilityInteraction(parameters);
        if (isPossible)
        {
            print($"Взаимодействие с объектом: {_selectedItem.Parameters.Name}");
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