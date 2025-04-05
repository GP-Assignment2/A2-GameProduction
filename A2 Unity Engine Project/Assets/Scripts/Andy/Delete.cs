using UnityEngine;

public class ObjectHide : MonoBehaviour
{
    private bool isVisible = true; // Tracks the visibility state of the GameObject

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true); // Ensure the GameObject starts as active
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) // Check if the 'C' key is pressed
        {
            isVisible = !isVisible; // Toggle the visibility state
            gameObject.SetActive(isVisible); // Show or hide the GameObject
        }
    }
}