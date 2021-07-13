using System;
using System.Collections;
using UnityEngine;

public class PhoneItem : Item
{
    [SerializeField] private GameObject _hideFlashlight;
    private AudioSource _source;
    private bool _isActive = false;

    private void Start()
    {
        _hideFlashlight.SetActive(false);
        _source = GetComponent<AudioSource>();
    }

    public override void InteractionStaticAction(ParametersItem parameters)
    {
    }
    
    public override void DynamicAction()
    {
    }
    
    public override void ActivasionAction()
    {
        if (!_isActive)
        {
            _source.Stop();
            StartCoroutine(Timer());
        }
    }

    private IEnumerator Timer()
    {
        EventManager.CellSelectMonologueText(TypeMonologue.CallPhone);
        yield return new WaitForSeconds(11.5f);
        EventManager.CellSelectMonologueText(TypeMonologue.Flashlight);
        _hideFlashlight.SetActive(true);
    }
    
}
