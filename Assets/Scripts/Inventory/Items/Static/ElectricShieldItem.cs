using System;
using UnityEngine;

public class ElectricShieldItem : Item
{
    [SerializeField] private Light[] _lights;
    [SerializeField] private GameObject _textGameOver;
    private bool _isActive;

    private void Awake()
    {
        _textGameOver.SetActive(false);
        _isActive = false;
    }

    public override void InteractionStaticAction(ParametersItem parameters)
    {
        if (!_isActive)
        {
            _textGameOver.SetActive(true);
            for (int i = 0; i < _lights.Length; i++)
            {
                _lights[i].enabled = true;
            }
        }
    }

    public override void DynamicAction()
    {
    }

    public override void ActivasionAction()
    {
    }
}