using System;

public class RemoteControllerItem : Item
{
    
    public override void InteractionStaticAction(ParametersItem parameters) { }
    
    public override void DynamicAction()
    {
        EventManager.EventSelectMonologueText(TypeMonologue.FoundRemoteControl);
    }
    
    public override void ActivasionAction()
    {
        
    }
}
