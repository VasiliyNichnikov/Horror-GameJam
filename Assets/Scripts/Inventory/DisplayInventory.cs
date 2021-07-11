using System;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    [SerializeField] private GameObject _inventory;

    private void Start()
    {
        _inventory.SetActive(false);
    }

    private void OnEnable()
    {
        EventManager.EventChangeStateInventory += ChangeStateInventory;
    }

    private void OnDisable()
    {
        EventManager.EventChangeStateInventory -= ChangeStateInventory;
    }

    private void ChangeStateInventory(bool state)
    {
        _inventory.SetActive(state);
    }

    private void Update()
    {
        InputKeyAndChangeState();
    }

    private void InputKeyAndChangeState()
    {
        if ((Input.GetKeyDown(KeyCode.Tab) && !ActionStaticItem.IsActiveInteration) ||
            (Input.GetKeyDown(KeyCode.Escape) && !ActionStaticItem.IsActiveInteration && _inventory.activeSelf))
        {
            ChangeStateInventory(!_inventory.activeSelf);
        }
    }
}