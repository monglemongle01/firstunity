using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private NavMeshAgent navemeshAgent;
    private RaycastHit raycastHit;
     void Start()
    {
        navemeshAgent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out raycastHit, Mathf.Infinity))
        {
            navemeshAgent.SetDestination(raycastHit.point);
        } 
    }
}
