using UnityEngine;
using System.Collections;

namespace ProjectSpace
{
    public class CameraController : MonoBehaviour
    {
        void Awake()
        {
            m_thisCamera = gameObject.GetComponent<Camera>();
        }
        void Update()
        {
            SettingTransformToTarget();
            Zoom();
        }


        [SerializeField]
        Camera m_thisCamera;

        [SerializeField]
        private GameObject m_target;

        [Header("Depth")]
        [SerializeField]
        private float m_maxDepth;
        [SerializeField]
        private float m_minDepth;

        [Header("Speed")]
        [SerializeField]
        private float m_speed = 0.1f;

        public void ChangeTarget(GameObject p_newTarget)
        {
            m_target = p_newTarget;
        }

        private Vector3 m_cameraPosition = new Vector3(0,0,-10f);
        private Quaternion m_cameraRotation;
        private void SettingTransformToTarget()
        {
            m_cameraPosition.x = m_target.transform.position.x;
            m_cameraPosition.y = m_target.transform.position.y;

            transform.position = m_cameraPosition;

            Vector3 rotate = m_thisCamera.transform.eulerAngles;
            rotate.x = m_target.transform.eulerAngles.x;
            rotate.z = m_target.transform.eulerAngles.z;
            transform.eulerAngles = rotate;
        }
        private void Zoom()
        {
            float cameraZ = m_cameraPosition.z;
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (cameraZ > m_maxDepth)
                {
                    m_cameraPosition += Vector3.back * m_speed;
                }
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                if (cameraZ  < m_minDepth)
                {
                    m_cameraPosition += Vector3.forward * m_speed;
                }
            }
        }
    }

}