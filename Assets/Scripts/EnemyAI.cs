using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    float speed;
    float stoppingDistance;
    float retreatDistance;

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,player.position)> stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        } else if (Vector3.Distance(transform.position, player.position) < stoppingDistance && Vector3.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }   else if(Vector3.Distance(transform.position, player.position)< retreatDistance){

            transform.position = Vector3.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }

    }
}