using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace ProjectSpace
{
    public class Battery : MonoBehaviour
    {
        public List<IMachine> machines { get; private set; }
        [SerializeField]
        private int m_max = 100;
        [SerializeField]
        private int m_energy = 0;
        public int energy
        {
            get { return m_energy; }
            private set
            {
                m_energy = value;
                if (m_energy > m_max) m_energy = m_max;
            }
        }

        public void Charge(int value)
        {
            energy += value;
        }
    }
}