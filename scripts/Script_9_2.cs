using UnityEngine;

public class Script_9_2 : MonoBehaviour
{
    public float speed = 2.0f;

    void Start()
    {
        
    }

    void Update()
    {
        MoveSphere();
    }

    private void MoveSphere()
    {
        float deltaX = 0.0f;
        float deltaZ = 0.0f;
        if (Input.GetKey(KeyCode.W))
        {
            deltaZ += speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            deltaZ -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            deltaX += speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            deltaX -= speed;
        }
        transform.Translate(deltaX, 0.0f, deltaZ);
    }
}
