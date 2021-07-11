using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    [SerializeField] private GameObject _inventory;

    private void Start()
    {
        _inventory.SetActive(false);
    }

    private void Update()
    {
        InputKeyAndChangeState();
    }

    private void InputKeyAndChangeState()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && !ActionStaticItem.IsActiveInteration)
        {
            _inventory.SetActive(!_inventory.activeSelf);
        }else if (ActionStaticItem.IsActiveInteration)
        {
            _inventory.SetActive(true);
        }
    }
    
}
