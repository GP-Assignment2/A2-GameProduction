using UnityEngine;

public class PlayOneShotSound : MonoBehaviour
{
    public AudioClip soundClip; // Drag your sound file here in the Inspector
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Press Spacebar to play the sound
        {
            audioSource.PlayOneShot(soundClip);
        }
    }
}
