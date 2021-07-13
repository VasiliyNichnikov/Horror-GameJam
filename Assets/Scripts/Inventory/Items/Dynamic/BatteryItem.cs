using UnityEngine;

public class BatteryItem : Item
{
    [SerializeField] private GameObject _remoteController;
    [SerializeField] private AudioSource _tvSource;
    private void Start()
    {
        _remoteController.SetActive(false);
    }
    
    public override void InteractionStaticAction(ParametersItem parameters)
    {
    }
    
    public override void DynamicAction()
    {
        _tvSource.Play();
        EventManager.CallSelectFlashlight();
        EventManager.CellSelectMonologueText(TypeMonologue.FindRemoteControl);
        _remoteController.SetActive(true);
    }
    
    public override void ActivasionAction()
    {
    }
}
