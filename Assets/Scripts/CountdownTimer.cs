using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour
{
    public static bool JogoAcabou;

    [SerializeField]
    GameObject MenuGameOver;

  

    public float currentTime = 000f;
    float startingTime = 180f;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
        MenuGameOver.SetActive(false);
        JogoAcabou = true;
       
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString ("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            EndGame();

        }


      
    }

    public void EndGame()
    {
        MenuGameOver.SetActive(true);
        JogoAcabou = true;
    }
}
