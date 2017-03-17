using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Table : MonoBehaviour
{
    private List<GameObject> m_onTableObjectList = new List<GameObject>();

    public void GetOn(GameObject p_object)
    {
        p_object.SetActive(false);
    }
}
