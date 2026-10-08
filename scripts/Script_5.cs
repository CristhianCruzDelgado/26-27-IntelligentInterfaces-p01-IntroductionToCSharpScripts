using UnityEngine;

public class Script5 : MonoBehaviour
{
    public Vector3 desplazamiento;

    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        float jumpInput = Input.GetAxis("Jump");
        if (jumpInput > 0f)
        {
            RelocateObject();
        }
    }

    private void RelocateObject()
    {
        transform.position = originalPosition + desplazamiento;
        Debug.Log(gameObject.name + " move to: " + transform.position);
    }
}
