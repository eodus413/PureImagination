using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ElectronicObject : MonoBehaviour
{
    [SerializeField]
    private int m_electrocityPowerToMove = 1;
    public virtual void Initialize(int p_electrocityPowerToMove = 1)
    {
        m_electrocityPowerToMove = p_electrocityPowerToMove;
    }
    protected virtual bool MoveCondition()
    {
        return true;
    }

    public void Move(int p_electrocityPower = 1)
    {
        if(p_electrocityPower >= m_electrocityPowerToMove)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if(MoveCondition())
                {
                    DoMove();
                }
            }
        }
    }
    protected virtual void DoMove() { }
}
