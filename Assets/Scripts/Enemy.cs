using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent agente;
    Transform alvo;

    [SerializeField]
    GameObject MenuGameOver;

    public static bool bacteriaApanhada;


    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        alvo = GameObject.FindGameObjectWithTag("Player").transform;
        MenuGameOver.SetActive(false);
        bacteriaApanhada = true;
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = alvo.position;
    }

    private void OnCollisionEnter(Collision Fire)
    {
        Destroy(gameObject);
    }

    public void ApanhadoPorBacteria()
    {

      MenuGameOver.SetActive(true);
            bacteriaApanhada = true;
    }

} 
