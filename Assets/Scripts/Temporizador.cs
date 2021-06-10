using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Temporizador : MonoBehaviour

{
    public float timeRemaining = 5;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        else
        {
            ComecarMenuPrincipal();
        }

    }
    
    public void ComecarMenuPrincipal()
    {
        SceneManager.LoadScene("Menu_Principal");
    }

}

