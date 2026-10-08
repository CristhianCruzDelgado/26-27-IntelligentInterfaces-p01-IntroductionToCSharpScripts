using UnityEngine;

public class Script_8 : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1.0f, 0.0f, 0.0f);
    public float speed = 2.0f;
    public Space spaceMode = Space.Self;

    void Start()
    {
        
    }

    void Update()
    {
        MoveCube();
    }

    private void MoveCube()
    {
        Vector3 displacement = moveDirection * speed * Time.deltaTime;
        transform.Translate(displacement.x, displacement.y, displacement.z, spaceMode);
    }
}
