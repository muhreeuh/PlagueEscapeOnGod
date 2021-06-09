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

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 15) * Time.deltaTime * 3);
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
