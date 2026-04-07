using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float jumpForce = 300.0f;
    public float moveSpeed = 0.03f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + (transform.right * 0.025f);
        }
        //Back
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + (transform.forward * -0.025f);
        }
        //Forward
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (transform.forward * 0.025f);
        }
        //Left
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (transform.right * -0.025f);
        }
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, jumpForce, 0.0f));
        }
    }
}
