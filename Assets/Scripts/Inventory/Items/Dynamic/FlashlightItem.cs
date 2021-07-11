public class FlashlightItem : Item
{
    public override void InteractionStaticAction(Item item)
    {
    }
    
    public override void DynamicAction()
    {
        EventManager.CallEventSelectFlashlight();
    }
}
