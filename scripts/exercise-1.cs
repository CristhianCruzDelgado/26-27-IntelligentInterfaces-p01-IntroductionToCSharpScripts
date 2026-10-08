using UnityEngine;

public class Script_1 : MonoBehaviour
{
    public int framesToWait = 240;
    
    private Color currentColor;
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        float r = UnityEngine.Random.Range(0f, 1f);
        float g = UnityEngine.Random.Range(0f, 1f);
        float b = UnityEngine.Random.Range(0f, 1f);
        currentColor = new Color(r, g, b);
        ApplyColor();
    }

    void Update()
    {
        if (Time.frameCount % framesToWait == 0)
        {
            ChangeRandomColorChannel();
            ApplyColor();
        }
    }

    private void ApplyColor()
    {
        if (objectRenderer != null)
        {
            objectRenderer.material.color = currentColor;
        }
    }

    private void ChangeRandomColorChannel()
    {
        int indexToChange = UnityEngine.Random.Range(0, 3);
        float newValue = UnityEngine.Random.Range(0f, 1f);

        switch (indexToChange)
        {
            case 0:
                currentColor.r = newValue;
                break;
            case 1:
                currentColor.g = newValue;
                break;
            case 2:
                currentColor.b = newValue;
                break;
        }
    }
}
