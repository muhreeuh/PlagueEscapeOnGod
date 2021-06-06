using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacina : MonoBehaviour
{
    public static bool JogoAcabou;

    [SerializeField]
    GameObject MenuGameOver;


    void Start()
    {
        
        MenuGameOver.SetActive(false);
        JogoAcabou = true;
    }


  

    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Player")
        {

            EndGame();
        }

        void EndGame()
        {
            MenuGameOver.SetActive(true);
            JogoAcabou = true;

        }
    }
}
