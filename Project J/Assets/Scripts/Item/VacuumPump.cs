using UnityEngine;
using System.Collections;

public class VacuumPump : Item
{
    [SerializeField]
    private VacuumDrum m_drum;

    public override void Initialize()
    {
        base.Initialize();
        durability = 10;
    }

    protected override void DoUse()
    {
        base.DoUse();
        m_drum.on = !m_drum.on;
    }
}
