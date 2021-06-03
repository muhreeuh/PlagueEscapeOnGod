using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SomPassos : MonoBehaviour
{
    public AudioSource PassosSom;
    // Start is called before the first frame update
    void Start()
    {
        PassosSom = GetComponent<AudioSource>();
        PassosSom.Play(0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
