using UnityEngine;

public class Script4 : MonoBehaviour
{
    [SerializeField] private float distanceToCube;
    [SerializeField] private float distanceToCylinder;

    private string cubeTag = "Cube";
    private string cylinderTag = "Cylinder";
    private GameObject cubeObject;
    private GameObject cylinderObject;

    void Start()
    {
        cubeObject = GameObject.FindWithTag(cubeTag);
        cylinderObject = GameObject.FindWithTag(cylinderTag);

        if (cubeObject == null)
        {
            Debug.LogWarning("Cube object not found!");
        }
        if (cylinderObject == null)
        {
            Debug.LogWarning("Cylinder object not found!");
        }
    }

    void Update()
    {
        if (cubeObject != null)
        {
            distanceToCube = Vector3.Distance(transform.position,
                                cubeObject.transform.position);
            Debug.Log("Distance to Cube: " + distanceToCube);
        }
        if (cylinderObject != null)
        {
            distanceToCylinder = Vector3.Distance(transform.position,
                                cylinderObject.transform.position);
            Debug.Log("Distance to Cylinder: " + distanceToCylinder);
        }
    }
}
