using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyContr : MonoBehaviour
{
	NavMeshAgent enemy;
    public Transform player;
    
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        enemy.SetDestination(player.transform.position);
    
 	}
}

