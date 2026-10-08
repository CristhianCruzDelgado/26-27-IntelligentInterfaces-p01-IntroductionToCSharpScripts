using UnityEngine;

public class Script_13 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 100f;

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
        transform.Rotate(0f, turnAmount, 0f);
        transform.Translate(0f, 0f, moveSpeed * Time.deltaTime);
    }

    private void DrawForwardRay()
    {
        Debug.DrawRay(transform.position, transform.forward * 3f, Color.red);
    }
}
