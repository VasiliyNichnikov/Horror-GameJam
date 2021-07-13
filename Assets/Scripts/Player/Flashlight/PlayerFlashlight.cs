using UnityEngine;

public class PlayerFlashlight : MonoBehaviour
{
    [SerializeField] private Light _light;

    private void Start()
    {
        _light.enabled = false;
    }

    private void OnEnable()
    {
        EventManager.EventSelectFlashlight += GettingFlashlight;
    }

    private void OnDisable()
    {
        EventManager.EventSelectFlashlight -= GettingFlashlight;
    }


    private void GettingFlashlight()
    {
        _light.enabled = true;
    }
}