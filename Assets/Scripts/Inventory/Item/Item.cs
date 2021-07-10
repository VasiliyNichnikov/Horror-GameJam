using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private ParametersItem _parameters;
    public ParametersItem Parameters => _parameters;
}
