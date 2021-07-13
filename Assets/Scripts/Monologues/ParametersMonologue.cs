using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Monologues", menuName = "Monologues/Monologue")]
public class ParametersMonologue: ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private TypeMonologue _type;
    [SerializeField][Range(0, 15)] private float _messageTime;
    [SerializeField] [TextArea(3, 5)] private string _text;
    
    public string Name => _name;
    public TypeMonologue Type => _type;
    public float MessageTime => _messageTime;
    public string Text => _text;
}