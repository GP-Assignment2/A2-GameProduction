using UnityEngine;

public class CubeLoopSound : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isPlaying = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;  // Enable looping
    }

    void OnMouseDown()
    {
        if (isPlaying)
        {
            audioSource.Stop();  // Stop the sound if it's already playing
        }
        else
        {
            audioSource.Play();  // Start playing the loop
        }
        isPlaying = !isPlaying;  // Toggle the state
    }
}
