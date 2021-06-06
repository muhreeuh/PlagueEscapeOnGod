using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacina : MonoBehaviour
{
    public static bool GanhouJogo;

    [SerializeField]
    GameObject MenuVitoria;


    void Start()
    {
        
        MenuVitoria.SetActive(false);
        GanhouJogo = true;
    }


  

    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Player")
        {

            Ganhar();
        }

      
    }

    public void Ganhar()
    {
        
            MenuVitoria.SetActive(true);
            GanhouJogo = true;

        
    }
}
