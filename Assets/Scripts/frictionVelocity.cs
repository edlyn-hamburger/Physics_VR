using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class frictionVelocity : MonoBehaviour
{
    private Rigidbody rb;
    private Transform position;
    private Collider carCollider;
    private PhysicMaterial physicMaterial;
   
    public GameObject car; 
   

    private double gravity;
    private float mass;
    
    private double normal;
   

    [SerializeField]
    //public Collider carWheelColliders;
    public Collider trackCollider; 




    public void Start()
    {
        //collisionBool = false;

        carCollider = GetComponent<Collider>();
        carCollider.enabled = false;
        physicMaterial = carCollider.material; 
        position = GetComponent<Transform>();

        
        gravity = 9.8;
        normal = mass * gravity;
        //theta = position.rotation.z; negative moves rotation to left

        //carWheelColliders = GetComponent<Collider>();


       

    }

    /*private void OnCollisionStay(Collision collision)
    {
        rb.AddForce(0f, 0f, 5f);
    }*/

   
    public void Update()
    {


       if(Input.GetKeyDown("space"))
        {
            carCollider.enabled = true;
            car.AddComponent<Rigidbody>();
            rb = GetComponent<Rigidbody>();
            //rb.
            mass = rb.mass;
        }

        //Debug.Log("Velocity" + rb.velocity.magnitude);
    }

    private void OnTriggerStay(Collider other)
    {
        rb.AddForce(transform.forward * 20);
    }

    public double dynamic_Friction()
    {
        /**
         * friction force is calculated 
         * f = mu * Normal Force 
         * mu = coeficient 
         * Normal Force = mass * gravity
         */

        double dynamicFriction;
        double mu;

        mu = physicMaterial.dynamicFriction; 
        dynamicFriction = mu * normal;

        return dynamicFriction;

    }

    public double static_Friction ()
    {
        /**
         * same as dynamic 
         */

        double staticFriction;
        double mu;

        mu = physicMaterial.staticFriction;
        staticFriction = mu * normal;

        return staticFriction; 
    }

}
