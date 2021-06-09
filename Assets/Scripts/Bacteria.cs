using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        void Update()
        {
            transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
