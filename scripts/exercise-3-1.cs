using UnityEngine;

public class Script_3_1 : MonoBehaviour
{
    public Vector3 spherePosition;

    void Start()
    {
        ShowPositionDirectProperty();
    }

    void Update()
    {
        ShowPositionDirectProperty();
    }

    private void ShowPositionDirectProperty()
    {
        spherePosition = transform.position;
        Debug.Log("Direct position: " + spherePosition);
    }
}
