using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


//движение врага на игрока
public class EnemyContr : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    public GameObject player;
    float distanceToPlayer;
    float distance=20f;
    float speed=-5f;
    Vector3 enemyPosition;

    void Start()
    {
       agent=GetComponent<UnityEngine.AI.NavMeshAgent>();
       enemyPosition=agent.transform.position;
    }
    
    void Update()
    {
        distanceToPlayer=Vector3.Distance(player.transform.position,agent.transform.position);

        if(distanceToPlayer<=distance){
            agent.SetDestination(player.transform.position);
        }
        else{
            agent.SetDestination(enemyPosition);
        }
    }

}
