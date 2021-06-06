using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VacinaFinal : MonoBehaviour
{
    




    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Player")
        {

            CreditosFinais();
        }


    }

    public void CreditosFinais()
    {

        SceneManager.LoadScene("Menu_Creditos");


    }
}