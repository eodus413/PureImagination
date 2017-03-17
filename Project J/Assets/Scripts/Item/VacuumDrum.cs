using UnityEngine;
using System.Collections;

public class VacuumDrum : MonoBehaviour
{
    [SerializeField]
    private bool m_on = false;
    public bool on
    {
        get { return m_on; }
        set { m_on = value; }
    }

    [SerializeField]
    private int m_waterCount = 0;
    [SerializeField]
    private int m_maxCount = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Water"))
        {
            if (on)
            {
                if (m_waterCount < m_maxCount)
                {
                    other.transform.position = transform.position;  //물을 진공통 좌표로 옮기고
                    other.gameObject.SetActive(false);              //오브젝트 비활성화
                    ++m_waterCount;                                 //물 갯수 증가
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.red; 
                }
            }
        }
    }
}
