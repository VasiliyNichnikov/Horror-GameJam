using System;
using UnityEngine;

public class SelectItems : MonoBehaviour
{
    [SerializeField] [Range(0, 20)] private float _maxDistanceRay;
    [SerializeField] private StoreItems _store;
    [SerializeField] private ActionsItems _actions;
    
    private HintItem _hintItem;
    private Transform _thisTransform;
    private GameObject _hitObject;
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

    private void Update()
    {
        GetItem();
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        Debug.DrawRay(_thisTransform.position, transform.TransformDirection(Vector3.forward) * 100, Color.yellow);
        if (Physics.Raycast(_thisTransform.position, transform.TransformDirection(Vector3.forward), out hit,
            _maxDistanceRay, _layerMask) && !ActionStaticItem.IsActiveInteration)
        {
            _hitObject = hit.collider.gameObject;
            _hintItem.SelectDisplayButton(true);
        }
        else
        {
            _hintItem.SelectDisplayButton(false);
        }
    }

    private void GetItem()
    {
        var state = WaitingInteractionItem();
        if (state)
        {
            _actions.TransmittingItem(_hitObject);
            _hitObject = null;
        }
    }
    
    private bool WaitingInteractionItem()
    {
        return Input.GetKeyDown(KeyCode.E) && _store.CheckAvailableSpace() && _hitObject != null;
    }
}