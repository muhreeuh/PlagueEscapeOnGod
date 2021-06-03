using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
  
    [SerializeField]
    GameObject player;  

    private Vector3 diferenca; 

    void Start()
    {
        diferenca = transform.position - player.transform.position; 
    }

    
    private void LateUpdate()
    {
        transform.position = player.transform.position + diferenca; 
    }
}
