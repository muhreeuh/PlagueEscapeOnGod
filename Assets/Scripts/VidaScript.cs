using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaScript : MonoBehaviour
{

    public static bool JogoAcabou;

    [SerializeField]
    GameObject MenuGameOver;


    float currentTime = 000f;
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
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Player")
        {

            Destroy(gameObject);
        }

    }
}