using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{

    public string myName = "none"; //this creates field in unity inspector

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World my name is " + myName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
