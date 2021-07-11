using System;
using UnityEngine;

[RequireComponent(typeof(ActionStaticItem))]
[RequireComponent(typeof(ActionDynamicItem))]
public class ActionsItems : MonoBehaviour
{
    private ActionStaticItem _staticItem;
    private ActionDynamicItem _dynamicItem;

    private void Start()
    {
        _staticItem = GetComponent<ActionStaticItem>();
        _dynamicItem = GetComponent<ActionDynamicItem>();
    }

    public void TransmittingItem(GameObject objHit)
    {
        Item item = SearchComponentItem(objHit);
        switch (item.Parameters.ConditionItem)
        {
            case ConditionItem.Dynamic:
                TransmittingDynamicItem(item, objHit);
                break;
            
            case ConditionItem.Static:
                TransmittingStaticItem(item);
                break;
        }
    }
    
    private void TransmittingStaticItem(Item item)
    {
        _staticItem.CallingInteraction(item);
    }

    private void TransmittingDynamicItem(Item item, GameObject objHit)
    {
        _dynamicItem.TakeItemAndDestroyObjHit(item, objHit);
    }
    
    /// <summary>
    /// Поиск компонента Item в объекте, в который попал игрок
    /// </summary>
    /// <param name="objHit"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    private Item SearchComponentItem(GameObject objHit)
    {
        Item item = objHit.GetComponent<Item>();
        if (item == null)
        {
            throw new Exception("Не удалось подобрать предмет, отсутствует скрипт Item");
        }
    
        return item;
    }
}
