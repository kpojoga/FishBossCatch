using UnityEngine;

public class MusicSettings : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
   
    public void TurnOn()
    {
        _audio.Play();
    }
   
    public void TurnOff()
    {
        _audio.Stop();
    }
}
