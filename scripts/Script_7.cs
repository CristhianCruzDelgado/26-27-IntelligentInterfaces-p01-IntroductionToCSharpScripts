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
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("Tecla 'H' física detectada por KeyCode.");
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Debug.Log("¡PUM! ... fire button: (Fire1)");
    }
}
