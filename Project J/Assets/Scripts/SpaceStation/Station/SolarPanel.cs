using UnityEngine;
using System.Collections;

namespace ProjectSpace
{
    public class SolarPanel : MonoBehaviour,IEletronicSource
    {
        void Start()
        {
            On();
        }


        [SerializeField]
        private int m_energy = 0;
        public int energy
        {
            get { return m_energy; }
            private set { m_energy = value; }
        }
        [SerializeField]
        private float m_upDelay = 10f;
        public float upDelay
        {
            get { return m_upDelay; }
            private set { m_upDelay = value; }
        }
        [Header("On/Off")]
        [SerializeField]
        private bool m_isOn = true;
        public bool isOn
        {
            get { return m_isOn; }
            private set { m_isOn = value; }
        }

        [SerializeField]
        Battery battery;

        public void ChargeEnergyToBattery()
        {
            battery.Charge(energy);
            energy = 0;
        }

        public void On()
        {
            isOn = true;
            StartCoroutine(Charge());
        }
        public void Off()
        {
            isOn = false;
        }

        IEnumerator Charge()
        {
            while (isOn)
            {
                ++energy;
                yield return new WaitForSeconds(upDelay);
            }
        }
        private float energyToBatteryDelay = 20f;
        IEnumerator EnergyToBattery()
        {
            while(isOn)
            {
                ChargeEnergyToBattery();
                yield return new WaitForSeconds(energyToBatteryDelay);
            }
        }
    }

}
