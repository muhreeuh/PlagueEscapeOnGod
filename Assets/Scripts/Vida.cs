using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public static bool JogoAcabou;

    [SerializeField]
    GameObject MenuGameOver;


    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 15) * Time.deltaTime * 3);
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.name =="Player")
        {
            CountdownTimer.adicionar = 30f;
            Destroy(gameObject);
        }

    }
}
