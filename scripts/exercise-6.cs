using UnityEngine;

public class Script_6 : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
    }

    void Update()
    {
        CheckArrowKeys();
    }

    private void CheckArrowKeys()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            float result = speed * verticalValue;
            Debug.Log("UpArrow result (speed * vertical): " + result);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            float result = speed * verticalValue;
            Debug.Log("DownArrow result (speed * vertical): " + result);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            float result = speed * horizontalValue;
            Debug.Log("RightArrow result (speed * horizontal): " + result);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float result = speed * horizontalValue;
            Debug.Log("LeftArrow result (speed * horizontal): " + result);
        }
    }
}
