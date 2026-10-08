using UnityEngine;

public class Script_9_1 : MonoBehaviour
{
    public float speed = 2f;

    void Start()
    {
    }

    void Update()
    {
        MoveCube();
    }

    private void MoveCube()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float deltaX = horizontalInput * speed;
        float deltaZ = verticalInput * speed;
        transform.Translate(deltaX, 0.0f, deltaZ);
    }
}
