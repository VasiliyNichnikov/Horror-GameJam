public class KeysItem : Item
{
    public override void InteractionStaticAction(ParametersItem parameters)
    {
    }

    public override void DynamicAction()
    {
        EventManager.CellSelectMonologueText(TypeMonologue.GoElectricalPanel);
    }

    public override void ActivasionAction()
    {
    }
}