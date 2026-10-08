using UnityEngine;

public class Script_11 : MonoBehaviour
{
    public Transform sphereTransform;
    public float speed = 3f;
    
    void Start()
    {
    }

    void Update()
    {
        MoveTowardsSphere();
    }

    private void MoveTowardsSphere()
    {
        if (sphereTransform == null)
        {
            return;
        }

        Vector3 direction = sphereTransform.position - transform.position;
        direction.y = 0f;
        Vector3 normalizedDirection = direction.normalized;
        Vector3 displacement = normalizedDirection * speed * Time.deltaTime;
        transform.Translate(displacement, Space.World);
    }
}
