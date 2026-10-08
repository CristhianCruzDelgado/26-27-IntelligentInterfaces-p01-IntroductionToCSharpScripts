using UnityEngine;

public class Script_8 : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1f, 0f, 0f);
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
        Vector3 displacement = moveDirection * speed * Time.deltaTime;
        transform.Translate(displacement.x, displacement.y, displacement.z, 
                            Space.Self);
    }
}
