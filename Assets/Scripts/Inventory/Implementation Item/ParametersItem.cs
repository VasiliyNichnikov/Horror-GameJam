using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]
public class ParametersItem : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private TypeItem _type;
    [SerializeField] private TypeItem _typeInteraction;
    [SerializeField] private ConditionItem conditionItem;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Sprite _icon;

    public string Name
    {
        get => _name;
    }

    public string Description
    {
        get => _description;
    }

    public TypeItem Type
    {
        get => _type;
    }

    public TypeItem TypeInteraction
    {
        get => _typeInteraction;
    }

    public ConditionItem ConditionItem
    {
        get => conditionItem;
    }
    
    public GameObject Prefab
    {
        get => _prefab;
    }
    
    public Sprite Sprite
    {
        get => _icon;
    }
}