using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyTankMovement : MonoBehaviour
{

    public float m_CloseDistance = 8f;
    public Transform m_Turret;

  
    private GameObject m_Player;
   
    private NavMeshAgent m_NavAgent;
  
    private Rigidbody m_Rigidbody;

  
    private bool m_Follow;

    private void Awake()
    {
        m_Player = GameObject.FindGameObjectWithTag("Player");
        m_NavAgent = GetComponent<NavMeshAgent>();
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Follow = false;
    }

    private void OnEnable()
    {

        m_Rigidbody.isKinematic = false;
    }

    private void OnDisable()
    {

        m_Rigidbody.isKinematic = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            m_Follow = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            m_Follow = false;
        }
    }



}