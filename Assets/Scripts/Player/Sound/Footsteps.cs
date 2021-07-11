using UnityEngine;
using Random = UnityEngine.Random;

public class Footsteps : MonoBehaviour
{
    [SerializeField] private AudioClip[] _floors;
    private AudioSource _source;
    private AudioClip _clip;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
        _source.playOnAwake = false;
        _source.mute = false;
        _source.loop = false;
        
    }

    public void PlayStep(Steps steps, float volume)
    {
        if(_source.isPlaying)
            return;
        
        switch (steps)
        {
            case Steps.Floor:
                _clip = _floors[Random.Range(0, _floors.Length)];
                break;
        }
        _source.PlayOneShot(_clip, volume);
    }
    
}
