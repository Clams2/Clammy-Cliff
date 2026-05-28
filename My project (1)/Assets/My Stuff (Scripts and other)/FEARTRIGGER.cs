using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FEARTRIGGER : MonoBehaviour
{

    public GameObject objectToMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
        objectToMove.GetComponent<Animator>().SetTrigger("TriggerFEAR");
        }
    }
}