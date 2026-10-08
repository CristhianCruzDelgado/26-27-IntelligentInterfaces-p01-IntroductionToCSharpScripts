using UnityEngine;

public class Script_10_1 : MonoBehaviour
{
    public float speed = 5f;

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
        float deltaX = horizontalInput * speed * Time.deltaTime;
        float deltaZ = verticalInput * speed * Time.deltaTime;
        transform.Translate(deltaX, 0f, deltaZ);
    }
}
