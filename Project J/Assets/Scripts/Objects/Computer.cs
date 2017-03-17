using UnityEngine;
using System.Collections;

public class Computer : ElectronicObject
{
    private bool m_playerCanUse = false;

    [SerializeField]
    private ComputerScreen m_screen;
    
    public override void Initialize(int p_electrocityPowerToMove)
    {
        base.Initialize(p_electrocityPowerToMove);
        m_screen.Initialize();
    }
    protected override bool MoveCondition()
    {
        if (m_playerCanUse)
        {
            if(base.MoveCondition())
            {
                return true;
            }
        }
        return false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            m_playerCanUse = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            m_playerCanUse = false;
        }
    }
    protected override void DoMove()
    {
        m_screen.Move();
    }
}
