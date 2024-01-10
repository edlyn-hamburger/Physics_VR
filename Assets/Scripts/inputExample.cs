using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space key was pressed");
        }   
    }
}
