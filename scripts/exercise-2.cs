using UnityEngine;

public class Script2 : MonoBehaviour
{
    public Vector3 firstVector = new Vector3(0.0f, 1.0f, 0.0f);
    public Vector3 secondVector = new Vector3(1.0f, 0.0f, 0.0f);

    [SerializeField] private float firstMagnitude;
    [SerializeField] private float secondMagnitude;
    [SerializeField] private float angleBetweenVectors;
    [SerializeField] private float distanceBetweenVectors;
    [SerializeField] private string highestVector;

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
        CalculateHeightBetweenVectors(firstVector.y, secondVector.y);

        Debug.Log("First Vector Magnitude: " + firstMagnitude);
        Debug.Log("Second Vector Magnitude: " + secondMagnitude);
        Debug.Log("Angle between vectors: " + angleBetweenVectors + "°");
        Debug.Log("Distance between vectors: " + distanceBetweenVectors);
        Debug.Log(highestVector);
    }

    private void CalculateHeightBetweenVectors(float firstY, float secondY)
    {
        if (firstY > secondY)
        {
            highestVector = "First Vector is at a higher altitude (Y: " + 
                            firstVector.y + ")";
        }
        else if (secondY > firstY)
        {
            highestVector = "Second Vector is at a higher altitude (Y: " + 
                            secondVector.y + ")";
        }
        else
        {
            highestVector = "Both vectors are at the same altitude (Y: " + 
                            firstVector.y + ")";
        }
    }
}
