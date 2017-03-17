using UnityEngine;
using System.Collections;

public class Spanner : Item
{
    public override void Initialize()
    {
        base.Initialize();
        itemRigdbody.mass = 0.1f;

    }
}
