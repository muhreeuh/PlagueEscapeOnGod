using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHelp : MonoBehaviour
{
    [SerializeField] Transform coordinate;
    [SerializeField] Rigidbody help;
    void OnTriggerEnter()
    {
        Rigidbody rigidHelp;
        rigidHelp = Instantiate(help, coordinate.position, Quaternion.identity) as Rigidbody;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);

        }
    }
}
