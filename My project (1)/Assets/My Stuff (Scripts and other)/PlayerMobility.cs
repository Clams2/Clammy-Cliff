using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMobility : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation *= Quaternion.Euler(0, 5, 0);
        } 
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation *= Quaternion.Euler(0, -5, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (transform.forward * 0.2f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + (transform.forward * -0.2f);
        }
    }
}
