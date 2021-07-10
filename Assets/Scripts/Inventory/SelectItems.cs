using System;
using UnityEngine;

public class SelectItems : MonoBehaviour
{
    [SerializeField] [Range(0, 20)] private float _maxDistanceRay;
    [SerializeField] private StoreItems _store;
    [SerializeField] private DrawInventoryUI _drawInventory;

    private HintItem _hintItem;
    private Transform _thisTransform;
    private int _layerMask = 1 << 8;

    private void Start()
    {
        _thisTransform = transform;
        _hintItem = GetComponent<HintItem>();

        if (_store == null)
        {
            throw new Exception("Хранилище с предметами не найдено");
        }
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        Debug.DrawRay(_thisTransform.position, transform.TransformDirection(Vector3.forward) * 100, Color.yellow);
        if (Physics.Raycast(_thisTransform.position, transform.TransformDirection(Vector3.forward), out hit,
            _maxDistanceRay, _layerMask))
        {
            GameObject objHit = hit.collider.gameObject;
            if (WaitingClickAndCheckStore(objHit))
            {
                Item item = SearchComponentItem(objHit);
                if (CheckingItemCanTaken(item))
                {
                    AddItemOnInventory(item);
                    _drawInventory.DrawCells();
                    Destroy(objHit);
                }
            }

            _hintItem.SelectDisplayButton(true);
        }
        else
        {
            _hintItem.SelectDisplayButton(false);
        }
    }

    private bool WaitingClickAndCheckStore(GameObject objHit)
    {
        return Input.GetKey(KeyCode.E) && _store.CheckAvailableSpace();
    }

    private Item SearchComponentItem(GameObject objHit)
    {
        Item item = objHit.GetComponent<Item>();
        if (item == null)
        {
            throw new Exception("Не удалось подобрать предмет, отсутствует скрипт Item");
        }

        return item;
    }

    private bool CheckingItemCanTaken(Item item)
    {
        return item.Parameters.TypeActionSubject == TypeActionSubject.SelectionInventory;
    }

    private void AddItemOnInventory(Item item)
    {
        print($"Предмет: {item.Parameters.Name}");
        _store.AddItem(item.Parameters);
    }
}