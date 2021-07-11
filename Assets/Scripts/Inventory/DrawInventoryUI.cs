using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawInventoryUI : MonoBehaviour
{
    [SerializeField] private StoreItems _store;
    [SerializeField] private Text _name;
    [SerializeField] private Text _description;
    [SerializeField] private CellItem[] _cells;

    public void Start()
    {
        for (int i = 0; i < _cells.Length; i++)
        {
            _cells[i].InitTextNameAndDescription(_name, _description);
        }

        ClearNameAndDescription();
    }
    
    private void ClearNameAndDescription()
    {
        _name.text = "";
        _description.text = "";
    }
    
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
        cell.SetIconAndItem(item);
    }
    
}
