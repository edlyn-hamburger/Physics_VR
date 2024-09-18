using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Friction : MonoBehaviour
{
    Rigidbody body;
    


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space bar pressed");
            body.AddForce(transform.forward * 500);
            //Debug.Log(dynamic_Friction());
        }
    }


}
