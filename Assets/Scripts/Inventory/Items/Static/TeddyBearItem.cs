using UnityEngine;

public class TeddyBearItem : Item
{
    [SerializeField] private ActionDynamicItem _actionDynamic;
    [SerializeField] private Item _eye;
    
    public override void InteractionStaticAction(ParametersItem parameters)
    {
        _actionDynamic.TakeItem(_eye);
    }
    
    public override void DynamicAction()
    {
    }
}
