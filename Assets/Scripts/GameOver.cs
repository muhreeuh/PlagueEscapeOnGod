using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject MenuGameOver;

    bool jogoAcabou = false;

    [SerializeField]
    float tempoDeEspera = 2f;

    float tempoDecorrido = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
        MenuGameOver.SetActive(false);
        jogoAcabou = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (jogoAcabou == false)
        {
            tempoDecorrido += Time.deltaTime;
            if (tempoDecorrido >= tempoDeEspera)
            {
                Debug.Log("GameOver");
                MenuGameOver.SetActive(true);
                jogoAcabou = true;

            }

        }
       

    }

   
}
