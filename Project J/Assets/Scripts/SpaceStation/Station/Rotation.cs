using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private float m_speed = 1f;
    void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        transform.Rotate(0, 0, m_speed * Time.deltaTime);
    }
}