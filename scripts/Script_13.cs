using UnityEngine;

public class Script_13 : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float turnSpeed = 100.0f;

    void Start()
    {

    }

    void Update()
    {
        MoveAndTurn();
        DrawForwardRay();
    }

    private void MoveAndTurn()
    {
        float turnInput = Input.GetAxis("Horizontal");
        float turnAmount = turnInput * turnSpeed * Time.deltaTime;
        transform.Rotate(0.0f, turnAmount, 0.0f);
        transform.Translate(0.0f, 0.0f, moveSpeed * Time.deltaTime);
    }

    private void DrawForwardRay()
    {
        Debug.DrawRay(transform.position, transform.forward * 3.0f, Color.red);
    }
}
