using UnityEngine;

public class Script_5 : MonoBehaviour
{
    public Vector3 displacement;

    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        CheckSpacebarKey();
    }

    private void CheckSpacebarKey()
    {
        float jumpInput = Input.GetAxis("Jump");

        if (jumpInput > 0f)
        {
            RelocateObject();
        }        
    }

    private void RelocateObject()
    {
        transform.position = originalPosition + displacement;
        Debug.Log(gameObject.name + " move to: " + transform.position);
    }
}
