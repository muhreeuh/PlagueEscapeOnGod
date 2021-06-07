using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaScript : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);

            float currentTime;
            currentTime = GameObject.Find("CountdownText").GetComponent<CountdownTimer>().currentTime;
            currentTime -= 1 * Time.deltaTime + 10f;
        }
    }
}