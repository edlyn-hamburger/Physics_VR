using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{

    public GameObject sphere; 
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        sphere.AddComponent<Rigidbody>();
        rb = sphere.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.AddForce(2f, 0f, 0f);
        }
        
    }
}
