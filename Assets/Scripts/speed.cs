using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidBod = GetComponent<Rigidbody>();
        float speed = Vector3.Magnitude(rigidBod.velocity);
        Debug.Log(speed); 
    }
}
