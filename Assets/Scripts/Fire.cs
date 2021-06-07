using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    [SerializeField]
    float force = 100f;

 

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
    }

}
