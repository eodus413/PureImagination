using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class WaterBottle : Item
{
    private int m_waterAmount = 10;
    private GameObject m_water;
    private List<GameObject> m_waterObjectPool;
    
    public override void Initialize()
    {
        base.Initialize();

        m_waterObjectPool = new List<GameObject>();
        
        m_water = Resources.Load("Prefabs/Object/Water") as GameObject;
        for (int i=0;i<m_waterAmount;++i)
        {
            m_waterObjectPool.Add(Instantiate(m_water, transform) as GameObject);
            m_waterObjectPool[i].SetActive(false);
        }
    }
    private void Destroy()
    {
        for(int i=0;i< m_waterAmount;++i)
        {
            m_waterObjectPool[i].SetActive(true);
        }
    }
}
