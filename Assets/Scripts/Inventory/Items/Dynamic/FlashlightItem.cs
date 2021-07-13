using UnityEngine;

public class FlashlightItem : Item
{
    [SerializeField] private GameObject _batteries;
    
    private void Start()
    {
        _batteries.SetActive(false);
    }
    
    public override void InteractionStaticAction(ParametersItem parameters)
    {
    }

    public override void DynamicAction()
    {
        EventManager.CellSelectMonologueText(TypeMonologue.Batteries);
        _batteries.SetActive(true);
    }
    
    public override void ActivasionAction()
    {
    }
}