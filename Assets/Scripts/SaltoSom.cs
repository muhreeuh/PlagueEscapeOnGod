using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoSom : MonoBehaviour
{
    [SerializeField] AudioSource passos;
    [SerializeField] AudioSource salto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.jump == true)
        {
            salto = GetComponent<AudioSource>();
            salto.Play();
        }
        
        if (PlayerMovement.jump == false)
        {
            salto.Pause();
        }

        
    }
}
