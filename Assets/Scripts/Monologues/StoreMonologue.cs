using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StoreMonologue : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private ParametersMonologue[] _monologues;
    private IEnumerator _timer;
    
    private void Start()
    {
        _text.text = "";
        // SelectMonologue(TypeMonologue.WifeIsGreeting);
    }
    
    private void OnEnable()
    {
        EventManager.EventSelectMonologueText += SelectMonologue;
    }

    private void OnDisable()
    {
        EventManager.EventSelectMonologueText -= SelectMonologue;
    }

    private void SelectMonologue(TypeMonologue type)
    {
        if (_timer != null)
        {
            StopCoroutine(_timer);
        }
        ParametersMonologue monologue = GetMonologue(type);
        _timer = Timer(monologue.Text, monologue.MessageTime);
        StartCoroutine(_timer);
    }

    private ParametersMonologue GetMonologue(TypeMonologue type)
    {
        for (int i = 0; i < _monologues.Length; i++)
        {
            if (_monologues[i].Type == type)
            {
                return _monologues[i];
            }
        }

        throw new Exception("Монолог не найден");
    }

    private IEnumerator Timer(string text, float seconds)
    {
        _text.text = text;
        yield return new WaitForSeconds(seconds);
        _text.text = "";
    }

    //
    // private void SelectTextMonologue(string text)
    // {
    //     _text.text = text;
    // }
}