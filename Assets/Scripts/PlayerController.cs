using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private Rigidbody rb;
    //private float speed;
    //private Collider objectCollider;
    private Vector3 centerOfCollider;
    //private Vector3 endOfCollider;
    //private Vector2 sizeOfCollider;
    private Vector3 minOfCollider;
    private GameObject childObject;
    private Component parentCoponent;
    private Collider parentCollider;

     
    void Start()
    {
        /**this a pushing an on object with an inital force might use but don't delete yet
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0f, 0f, 50f); //x y z**/

        //rb = GetComponent<Rigidbody>(); // getting rigid body component
        //objectCollider = GetComponent<Collider>(); // getting object collider 

        //speed = 5f;

        parentCollider = GetComponentInParent<Collider>();
        //minOfCollider = parentCollider.bounds.min;

        centerOfCollider = parentCollider.bounds.center;
        /**endOfCollider = objectCollider.bounds.max;
        sizeOfCollider = objectCollider.bounds.size;
        minOfCollider = objectCollider.bounds.min;

        StartCoroutine(velocityRoutine());**/
        outPutData();
    }

    /**IEnumerator velocityRoutine()
    {
        rb.velocity = new Vector3(0f, 0f, speed);
        Debug.Log("about to yield return");
        yield return null;
    }**/

    void outPutData()
    {
        Debug.Log("The min of the collider called through the child object " + minOfCollider);
        Debug.Log("This is the center  " + centerOfCollider);
        //Debug.Log("This is the size & min of the collider: " +  sizeOfCollider + minOfCollider);
        //Debug.Log("Object Name: " + parentObject.name);
     
    }

  
}
