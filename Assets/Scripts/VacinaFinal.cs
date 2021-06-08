using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VacinaFinal : MonoBehaviour
{
    public static bool FinalNivel2;

    [SerializeField]
    GameObject MenuFinal;


    private void Start()
    {
        MenuFinal.SetActive(false);
        FinalNivel2 = true;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Player")
        {

            CreditosFinais();
        }


    }

    public void CreditosFinais()
    {

        MenuFinal.SetActive(true);
        FinalNivel2 = true;

    }
}