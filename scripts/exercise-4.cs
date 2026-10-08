using UnityEngine;

public class Script_4 : MonoBehaviour
{
    public float distanceToCube;
    public float distanceToCylinder;

    private GameObject cubeObject;
    private GameObject cylinderObject;

    void Start()
    {
        cubeObject = GameObject.FindWithTag("cube");
        cylinderObject = GameObject.FindWithTag("cylinder");

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
