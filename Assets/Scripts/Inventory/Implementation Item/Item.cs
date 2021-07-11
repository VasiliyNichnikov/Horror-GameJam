using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] protected ParametersItem _parameters;
    public ParametersItem Parameters => _parameters;

    public abstract void InteractionStaticAction(Item item);
}