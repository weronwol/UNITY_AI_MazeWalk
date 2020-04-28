using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiWalking : MonoBehaviour
{
    public NavMeshAgent agent;    //宣告NavMeshAgent
    public GameObject target;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
}
