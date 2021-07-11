using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] protected ParametersItem _parameters;
    public ParametersItem Parameters => _parameters;

    public abstract void InteractionStaticAction(Item item);

    // protected bool CheckingPossibilityInteraction(Item item)
    // {
    //     ParametersItem parameters = item.Parameters;
    //     return _parameters.Type == parameters.TypeInteraction &&
    //            _parameters.ConditionItem != parameters.ConditionItem;
    // }
}