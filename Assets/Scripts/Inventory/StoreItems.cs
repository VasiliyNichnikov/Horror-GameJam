using System.Collections.Generic;
using UnityEngine;

public class StoreItems : MonoBehaviour
{
    [SerializeField] private int _maximumInventorySize;
    private List<ParametersItem> _items;

    public List<ParametersItem> Items => _items;

    private void Start()
    {
        _items = new List<ParametersItem>();
    }
    
    public void AddItem(ParametersItem item)
    {
        _items.Add(item);
        print("Предмет взят");
    }
    
    public void DeleteItem(int index)
    {
        _items.RemoveAt(index);
    }
    
    public bool CheckAvailableSpace()
    {
        return _maximumInventorySize != _items.Count;
    }
}
