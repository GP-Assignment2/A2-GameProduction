using UnityEngine;

public class ObjectManipulation : MonoBehaviour
{
    public GameObject targetObject;       // Object to show/hide
    public GameObject objectToInstantiate; // Prefab to create
    private GameObject spawnedObject;     // Track spawned object

    void Update()
    {
        // A) Toggle visibility
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (targetObject != null)
            {
                bool isActive = targetObject.activeSelf;
                targetObject.SetActive(!isActive);
                Debug.Log("Toggled visibility: " + !isActive);
            }
        }

        // B) Instantiate on left mouse click
        if (Input.GetMouseButtonDown(0))
        {
            if (objectToInstantiate != null && spawnedObject == null)
            {
                spawnedObject = Instantiate(objectToInstantiate, new Vector3(3f, -115f, -184f), Quaternion.identity);
                Debug.Log("Object instantiated!");
            }
        }

        // C) Destroy on 'D' key
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (spawnedObject != null)
            {
                Destroy(spawnedObject);
                Debug.Log("Spawned object destroyed!");
            }
        }
    }
}
