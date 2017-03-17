using UnityEngine;
using System.Collections;

public class ComputerScreen : ElectronicObject
{
    private bool m_on = false;
    
    protected override void DoMove()
    {
        m_on = !m_on;
        gameObject.SetActive(m_on);     //컴퓨터 스크린의 활성화 상태를 현재의 반대값으로 바꿈
    }
}
