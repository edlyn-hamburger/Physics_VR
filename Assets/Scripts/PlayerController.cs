using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private Rigidbody rb;
    //private float speed;
    private Collider objectCollider;
    private Vector3 centerOfCollider;
    private Vector3 endOfCollider;
    void Start()
    {
        /**this a pushing an on object with an inital force might use but don't delete yet
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0f, 0f, 50f); //x y z**/  

        //rb = GetComponent<Rigidbody>(); // getting rigid body component
        objectCollider = GetComponent<Collider>(); // getting object collider 

        //speed = 5f;
        //StartCoroutine(velocityRoutine());

        centerOfCollider = objectCollider.bounds.center;
        endOfCollider = objectCollider.bounds.extents;

        outPutData();
    }

    void outPutData()
    {
        Debug.Log("The center of the collider " + centerOfCollider);
        Debug.Log("This is the extent idk if it means the end perse " + endOfCollider);
    }

    /**IEnumerator velocityRoutine()
    {
        rb.velocity = new Vector3(0f, 0f, speed);
        Debug.Log("about to yield return");
        yield return null;
    }**/
}
