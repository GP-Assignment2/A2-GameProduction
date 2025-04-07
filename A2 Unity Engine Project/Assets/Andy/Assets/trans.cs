using UnityEngine;

public class trans : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Color originalColor = spriteRenderer.color; // Get the original color
        spriteRenderer.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0.5f);
    }
}
