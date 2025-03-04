using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce_test : MonoBehaviour
{
     public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void AddForce(Vector3 force)
    {
        if (rb != null)
        {
            rb.AddForce(force, ForceMode.Force);
        }
    }

    // Вторая перегрузка: добавляет силу по вектору с заданной силой и режимом силы
    public void AddForce(Vector3 force, ForceMode mode)
    {
        if (rb != null)
        {
            rb.AddForce(force, mode);
        }
    }

    // Третья перегрузка: добавляет силу вдоль оси X с заданной величиной и режимом силы
    public void AddForce(float xForce, ForceMode mode)
    {
        if (rb != null)
        {
            Vector3 forceVector = new Vector3(xForce, 0f, 0f);
            rb.AddForce(forceVector, mode);
        }
    }

    // Четвертая перегрузка: добавляет силу вдоль оси Y с заданной величиной и режимом силы
    public void AddForce(float yForce, float zForce, ForceMode mode)
    {
        if (rb != null)
        {
            Vector3 forceVector = new Vector3(0f, yForce, zForce);
            rb.AddForce(forceVector, mode);
        }
    }
}
