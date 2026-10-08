using UnityEngine;

public class Script_12 : MonoBehaviour
{
    public Transform sphereTransform;
    public float speed = 3.0f;

    void Start()
    {

    }

    void Update()
    {
        LookAndFollowSphere();
    }

    private void LookAndFollowSphere()
    {
        if (sphereTransform == null)
        {
            return;
        }
        transform.LookAt(sphereTransform);
        Vector3 displacement = Vector3.forward * speed * Time.deltaTime;
        transform.Translate(displacement, Space.Self);
    }
}
