using UnityEngine;

public class ActionDynamicItem : MonoBehaviour
{
    [SerializeField] private DrawInventoryUI _drawInventory;
    private StoreItems _store;

    private void Start()
    {
        _store = GetComponent<StoreItems>();
    }

    public void TakeItemAndDestroyObjHit(Item item, GameObject objHit)
    {
        item.DynamicAction();
        AddItemAndDrawCells(item);
        Destroy(objHit);
    }
    
    public void TakeItem(Item item)
    {
        item.DynamicAction();
        AddItemAndDrawCells(item);
    }

    private void AddItemAndDrawCells(Item item)
    {
        AddItemOnInventory(item);
        _drawInventory.DrawCells();
    }
    
    private void AddItemOnInventory(Item item)
    {
        print($"Предмет: {item.Parameters.Name}");
        _store.AddItem(item.Parameters);
    }
}