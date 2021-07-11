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
        AddItemOnInventory(item);
        _drawInventory.DrawCells();
        Destroy(objHit);
    }

    private void AddItemOnInventory(Item item)
    {
        print($"Предмет: {item.Parameters.Name}");
        _store.AddItem(item.Parameters);
    }
}