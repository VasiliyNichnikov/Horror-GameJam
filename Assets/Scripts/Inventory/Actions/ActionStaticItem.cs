using System.Collections.Generic;
using UnityEngine;

public class ActionStaticItem : MonoBehaviour
{
    private StoreItems _store;

    private void Start()
    {
        _store = GetComponent<StoreItems>();
    }

    public void CallingInteraction(Item item)
    {
        var isPossible = CheckingPossibilityInteraction(item);
        if (isPossible)
        {
            print($"Взаимодействие с объектом: {item.Parameters.Name}");
        }
        else
        {
            print("Игрок не имеет нужного предмета для взаимодействия");
        }
    }

    private bool CheckingPossibilityInteraction(Item item)
    {
        List<ParametersItem> parametersItems = _store.Items;
        foreach (var parametersItem in parametersItems)
        {
            if (parametersItem.TypeInteraction == item.Parameters.Type)
                return true;
        }

        return false;
    }
}