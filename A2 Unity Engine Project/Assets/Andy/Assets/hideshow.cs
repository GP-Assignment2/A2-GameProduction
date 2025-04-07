using UnityEngine;

public class HideShow : MonoBehaviour
{
    public GameObject targetObject; // Assign the GameObject to show/hide in the Inspector
    private bool isVisible = true;  // Tracks the visibility state of the target GameObject

    void Update()
    {
        // Check if the 'C' key is pressed
        if (Input.GetKeyDown(KeyCode.C))
        {
            isVisible = !isVisible; // Toggle the visibility state

            // Toggle the Renderer component to show/hide the object
            Renderer renderer = targetObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.enabled = isVisible;
            }
        }
    }
}