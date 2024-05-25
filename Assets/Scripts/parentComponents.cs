using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Original Collider size for this object is x=20, y=1, z=305 at 0 0 107
 * for collider testing with parent changed to x=20, y=1, z=50
 * at center 0 0 230**/
public class parentComponents : MonoBehaviour 
{
    private Collider a_collider; 
    private Vector3 minVectorCollider;

    public void Start()
    {
        a_collider = GetComponent<Collider>();

        getCollider(); 
    }
    public Vector3 getCollider()
    { 
        minVectorCollider = a_collider.bounds.min;
        Debug.Log("Vector from collider: " + minVectorCollider);
        return minVectorCollider; 
    }
    /**public void childMovement()
    {
        rbChild = GetComponentInChildren<Rigidbody>();
        colliderChild = GetComponentInChildren<Collider>();
        Debug.Log("Child collider: " + colliderChild);

    }**/


    
}
