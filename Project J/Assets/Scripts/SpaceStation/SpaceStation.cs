using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace ProjectSpace
{
    public class SpaceStation : MonoBehaviour
    {
        [SerializeField]
        private float m_distance;
        private Battery m_battery;

        public void SetDistance(float value)
        {
            m_distance = value;
            transform.localPosition = new Vector3(m_distance, m_distance, 0);
        }
    }

}