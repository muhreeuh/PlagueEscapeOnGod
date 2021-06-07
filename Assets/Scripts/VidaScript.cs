using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaScript : MonoBehaviour
{
  
    public static bool JogoAcabou;

    [SerializeField]
    GameObject MenuGameOver;


    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Player")
        {

            Destroy(gameObject);
        }

    }
}