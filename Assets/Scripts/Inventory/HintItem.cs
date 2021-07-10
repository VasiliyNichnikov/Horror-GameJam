using UnityEngine;

public class HintItem : MonoBehaviour
{
    [SerializeField] private GameObject _button;
    
    private void Awake()
    {
        _button.SetActive(false);
    }

    public void SelectDisplayButton(bool state)
    {
        _button.SetActive(state);
    }
    
}
