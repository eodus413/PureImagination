using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class Shutter : ElectronicObject
{
    private bool m_isOpen;

    private BoxCollider2D m_collider;

    public void Initialize()
    {
        m_isOpen = false;
        m_collider = gameObject.GetComponent<BoxCollider2D>();
    }

    protected override void DoMove()
    {
        Debug.Log("DoMove");
        if (m_isOpen)
        {
            Debug.Log("open");
            transform.localEulerAngles = new Vector3(0, 90, 0);
        }
        else
        {
            Debug.Log("close");
            transform.localEulerAngles = Vector3.zero;
        }
        m_collider.isTrigger = m_isOpen;
    }
}
