using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    NavMeshAgent agente;
    Transform alvo;
   
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();

        alvo = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void Update()
    {
        agente.destination = alvo.position;
    }
}
