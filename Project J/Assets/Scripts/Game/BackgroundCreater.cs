using UnityEngine;
using System.Collections;

public class BackgroundCreater : MonoBehaviour
{
    [SerializeField]
    private GameObject m_boardPrefab;

    [SerializeField]
    private int m_size = 5;
    [SerializeField]
    private Transform m_holder;

    void Awake()
    {
        m_boardPrefab = Resources.Load("Prefabs/Background/Background") as GameObject;
        Vector3 position = Vector3.zero;
        for (int i = 0; i < m_size; ++i)
        {
            for (int j = 0; j < m_size; ++i)
            {
                position.x = m_holder.position.x + i;
                position.y = m_holder.position.y + j;
                GameObject instance = Instantiate(m_boardPrefab,position,Quaternion.identity) as GameObject;
            }
        }
    }
}
