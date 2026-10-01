using UnityEngine;

public class Script3 : MonoBehaviour
{
    [SerializeField] private Vector3 spherePosition;

    void Start()
    {
        ShowPositionDirectProperty();
    }

    void Update()
    {
        ShowPositionGetComponent();
    }

    private void ShowPositionDirectProperty()
    {
        spherePosition = transform.position;
        Debug.Log("Direct position: " + spherePosition);
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
