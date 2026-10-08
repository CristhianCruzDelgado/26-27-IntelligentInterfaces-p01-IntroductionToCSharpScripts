using UnityEngine;

public class Script_2 : MonoBehaviour
{
    public Vector3 firstVector = new Vector3(0f, 1f, 0f);
    public Vector3 secondVector = new Vector3(1f, 0f, 0f);
    public float firstMagnitude;
    public float secondMagnitude;
    public float angleBetweenVectors;
    public float distanceBetweenVectors;

    void Start()
    {
        CalculateAndShowProperties();
    }

    void Update()
    {
        CalculateAndShowProperties();
    }

    private void CalculateAndShowProperties()
    {
        firstMagnitude = firstVector.magnitude;
        secondMagnitude = secondVector.magnitude;
        angleBetweenVectors = Vector3.Angle(firstVector, secondVector);
        distanceBetweenVectors = Vector3.Distance(firstVector, secondVector);
        Debug.Log("First Vector Magnitude: " + firstMagnitude);
        Debug.Log("Second Vector Magnitude: " + secondMagnitude);
        Debug.Log("Angle between vectors: " + angleBetweenVectors + "°");
        Debug.Log("Distance between vectors: " + distanceBetweenVectors);
        ShowHeightestVector(firstVector.y, secondVector.y);
    }

    private void ShowHeightestVector(float firstY, float secondY)
    {
        string highestVector;

        if (firstY > secondY)
        {
            highestVector = "First Vector is higher: Y=" + firstVector.y;
        }
        else if (secondY > firstY)
        {
            highestVector = "Second Vector is higher: Y=" + secondVector.y;
        }
        else
        {
            highestVector = "Both vectors are equal: Y=" + firstVector.y;
        }

        Debug.Log(highestVector);
    }
}
