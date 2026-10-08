using UnityEngine;

public class Script_10_2 : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
    }

    void Update()
    {
        MoveSphere();
    }

    private void MoveSphere()
    {
        float deltaX = 0f;
        float deltaZ = 0f;
        float frameDistance = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            deltaZ += frameDistance;
        }
        if (Input.GetKey(KeyCode.S))
        {
            deltaZ -= frameDistance;
        }
        if (Input.GetKey(KeyCode.D))
        {
            deltaX += frameDistance;
        }
        if (Input.GetKey(KeyCode.A))
        {
            deltaX -= frameDistance;
        }

        transform.Translate(deltaX, 0f, deltaZ);
    }
}
