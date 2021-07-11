using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] protected ParametersItem _parameters;
    public ParametersItem Parameters => _parameters;
    
    public abstract void InteractionStaticAction(ParametersItem parameters);

    public abstract void DynamicAction();

    public abstract void ActivasionAction();
}