﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

   [SerializeField] float velocidade = 4f;
    Vector3 frontal, lateral;

    Vector3 playerOriginalPosition;
    Quaternion playerOriginalOrientation; 

    void Start()
    {
        playerOriginalPosition = transform.position;
        playerOriginalOrientation = transform.rotation;

        frontal = transform.forward;
        lateral = Quaternion.Euler(new Vector3(0, 90, 0)) * frontal;
    }

    
    void Update()
    {
        Vector3 horizontal = lateral * velocidade * Time.deltaTime * Input.GetAxis("Horizontal");
        Vector3 vertical = frontal * velocidade * Time.deltaTime * Input.GetAxis("Vertical");

        Vector3 movimento = horizontal + vertical;
        transform.position += movimento;
        transform.LookAt(transform.position + movimento);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Respawn"))
        {
            transform.position = playerOriginalPosition;
            transform.rotation = playerOriginalOrientation;
        }
    }
}