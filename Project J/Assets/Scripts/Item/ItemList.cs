using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemList
{
    private List<Item> m_list = new List<Item>();

    private List<GameObject> m_prefabList = new List<GameObject>();

    public void Initialize()
    {
        m_prefabList.Add(Resources.Load("Prefabs/Item/WaterBottle") as GameObject);
        m_prefabList.Add(Resources.Load("Prefabs/Item/Spanner") as GameObject);
    }
    public void AddItem(Item p_newItem)
    {
        m_list.Add(p_newItem);
    }
    public Item GetItem(string p_name)
    {
        for (int i = 0; i < m_list.Count; ++i)
        {
            if (m_list[i].itemName == p_name)
            {
                return m_list[i];
            }
        }
        return null;
    }
    public Item GetItem(int index)
    {
        return m_list[index];
    }
}
