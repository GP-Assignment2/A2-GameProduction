using UnityEngine;
using UnityEngine.UI;

public class UIButtonHandler : MonoBehaviour
{
    public Button myButton;

    void Start()
    {
        if (myButton != null)
        {
            myButton.onClick.AddListener(() => OnButtonClick(true)); // True for mouse click
        }
    }

    void Update()
    {
        // Check for keyboard input (Spacebar or Enter key)
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            OnButtonClick(false); // False for keyboard press
        }
    }

    void OnButtonClick(bool isMouseClick)
    {
        if (isMouseClick)
        {
            Debug.Log("Button Clicked with Mouse!");
        }
        else
        {
            Debug.Log("Button Activated with Keyboard!");
        }
    }
}
