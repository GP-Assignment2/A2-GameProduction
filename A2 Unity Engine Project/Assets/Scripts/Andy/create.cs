using UnityEngine;

public class create : MonoBehaviour
{
    public GameObject prefab; // Assign a prefab in the Inspector to spawn

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) // Check if the 'C' key is pressed
        {
            // Instantiate the prefab at the spawn point or at the origin
            if (prefab != null)
            {
                Instantiate(prefab);
            }

        }
    }
}