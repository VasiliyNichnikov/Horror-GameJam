using System.Collections.Generic;
using UnityEngine;

public class DrawInventoryUI : MonoBehaviour
{
    [SerializeField] private StoreItems _store;
    [SerializeField] private CellItem[] _cells;

    public void DrawCells()
    {
        List<ParametersItem> items = _store.Items;

        for (int i = 0; i < items.Count; i++)
        {
            SelectIconCell(_cells[i], items[i]);
        }
    }

    private void SelectIconCell(CellItem cell, ParametersItem item)
    {
        cell.SetIcon(item.Sprite);
    }
    
}
