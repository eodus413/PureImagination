using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Item : MonoBehaviour
{
    [SerializeField]
    private string m_name;
    public string itemName
    {
        get
        {
            return m_name;
        }
    }

    private Sprite m_itemImage;

    [SerializeField]
    private int m_durability;   //내구도
    public int durability
    {
        get { return m_durability; }
        set { m_durability = value; }
    }

    private Rigidbody2D m_itemRigidbody;
    private BoxCollider2D m_itemCollider;

    private KeyCode m_keycodeUse = KeyCode.Space;

    public bool isCanUse    //아이템의 사용 가능 여부 체크
    {
        get
        {
            if(m_durability > 0 && SpecialCondition())
            {
                if(Input.GetKeyDown(m_keycodeUse))
                {
                    return true;
                }
            }
            return false;
        }
    }
    protected Rigidbody2D itemRigdbody
    {
        get
        {
            return m_itemRigidbody;
        }
        set
        {
            m_itemRigidbody = value;
        }
    }
    
    public virtual void Initialize()
    {
        m_itemImage = gameObject.GetComponent<SpriteRenderer>().sprite;
        m_itemCollider = gameObject.GetComponent<BoxCollider2D>();
        m_itemRigidbody = gameObject.GetComponent<Rigidbody2D>();

        m_itemRigidbody.gravityScale = 0;
    }
    public void Use()
    {
        if(isCanUse)
        {
            DoUse();
        }
    }
    protected virtual void DoUse()
    {
        DurabilityDecrease();
    }
    protected virtual void DurabilityDecrease()
    {
        --m_durability;
    }
    protected virtual bool SpecialCondition()   //아이템마다 사용을 위한 특수조건
    {
        return true;
    }
}
