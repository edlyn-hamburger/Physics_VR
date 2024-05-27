using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Transform position;
    private float endPosition;
    
    
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        position = GetComponent<Transform>();

        StartCoroutine(movingForce()); 
    }

    /**public void Update()
    {
        
        if (position.localPosition.z < 207f)
        {
            Debug.Log("Inside if statement");
            rb.AddForce(0f, 0f, 0f);
        }
        else
        {
            rb.AddForce(0f, 0f, 5f);
            Debug.Log("Inside else statment, local position: " + position.localPosition.z);
        }
        
    }**/

    public IEnumerator movingForce()
    {
        while (position.localPosition.z > 207f) //while object is not at end position
        {
            Debug.Log("Inside while statement");
            rb.velocity = new Vector3(0f,0f,5f); //put velocity on object 
            yield return 0;// yield return waits for next frame
        }
  
    }

}