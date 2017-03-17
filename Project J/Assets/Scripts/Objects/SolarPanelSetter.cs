using UnityEngine;
using System.Collections;

public class SolarPanelSetter : MonoBehaviour
{
    private GameObject m_solarPanelPrefab;

    public void Initialize()
    {
        m_solarPanelPrefab = Resources.Load("Prefabs/SpaceStation/Station/SolarPanel") as GameObject;
    }

}