using UnityEngine;

public class Script_3_2 : MonoBehaviour
{
    public Vector3 spherePosition;

    void Start()
    {
        ShowPositionGetComponent();
    }

    void Update()
    {
        ShowPositionGetComponent();
    }

    private void ShowPositionGetComponent()
    {
        Transform transformComponent = GetComponent<Transform>();
        
        if (transformComponent != null)
        {
            spherePosition = transformComponent.position;
            Debug.Log("GetComponent position: " + spherePosition);
        }
    }
}
