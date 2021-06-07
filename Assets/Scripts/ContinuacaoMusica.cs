using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinuacaoMusica : MonoBehaviour
{
    //public GameObject Musica;


    public void NaoDestruirSom()
    {
        DontDestroyOnLoad(transform.gameObject);
    }




   // private void Awake()
   // {
   //     if (BotaoCreditos.Input.GetMouseButtonDown(0))
   //     {
   //         DontDestroyOnLoad(transform.gameObject);
   //     }
   //
   //
   // }
}
