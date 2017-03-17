using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Player : MonoBehaviour
{
    private Rigidbody2D m_playerRigidbody;
    [SerializeField]
    private float m_speed = 1f;
    private float m_rotationSpeed = 0.3f;
    [SerializeField]
    private GameObject m_boost;

    [SerializeField]
    private GameObject m_leftArm;
    [SerializeField]
    private GameObject m_rightArm;


    private Item m_item;

    void Start()
    {
        m_playerRigidbody = gameObject.GetComponent<Rigidbody2D>();
        m_playerRigidbody.gravityScale = 0;
        m_playerRigidbody.freezeRotation = true;
    }

    private void UseItem(Item p_item)
    {
        if(Input.GetKey(KeyCode.Space))
        {
            m_item = p_item;
        }
    }
    void Update()
    {
        m_boost.SetActive(false);
        if (Input.GetKey(KeyCode.W))
        {
            m_playerRigidbody.AddForce(transform.up * m_speed);
            m_boost.transform.localRotation = Quaternion.Euler(0, 0, 180);
            m_boost.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            m_playerRigidbody.AddForce(-1 * transform.up * m_speed);
            m_boost.transform.localRotation = Quaternion.Euler(0, 0, 0);
            m_boost.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            m_playerRigidbody.AddForce(transform.right * m_speed);
            m_boost.transform.localRotation = Quaternion.Euler(0, 0, 90);
            m_boost.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            m_playerRigidbody.AddForce(-1 * transform.right * m_speed);
            m_boost.transform.localRotation = Quaternion.Euler(0, 0, -90);
            m_boost.SetActive(true);
        }
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, -m_rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, m_rotationSpeed);
        }
    }
}
