using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1;

    public void Play()
    {
        src.clip = sfx1;
        src.Play();
    }
}
