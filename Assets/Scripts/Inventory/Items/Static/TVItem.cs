using System;
using UnityEngine;

public class TVItem : Item
{
    [SerializeField] private GameObject _handler;
    [SerializeField] private Light[] _lights;
    [SerializeField] private AudioSource _source;
    private bool _isActive = false;

    private void Start()
    {
        _handler.SetActive(false);
        _source = GetComponent<AudioSource>();
    }

    public override void InteractionStaticAction(ParametersItem parameters)
    {
        if(!_isActive)
        {
            _source.Stop();
            EventManager.CellSelectMonologueText(TypeMonologue.FindKey);

            for (int i = 0; i < _lights.Length; i++)
            {
                _lights[i].enabled = false;
            }
            _handler.SetActive(true);
            _isActive = true;
        }
    }
    
    public override void DynamicAction()
    {
    }
    
    public override void ActivasionAction()
    {
    }
}
