using UnityEngine;

public class Script_7 : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        CheckFireInput();
    }

    private void CheckFireInput()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("¡PUM! ... fire button: (Fire1)");
        }
    }
}
