using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class frictionVelocity : MonoBehaviour
{
    private Rigidbody rb;
    private Transform position;
    private Collider objectCollider;
    private PhysicMaterial physicMaterial;
    private Canvas canvas;
     
   

    private double gravity;
    private float mass;
    private float theta; 
    
    private double normal;
    private bool collisionBool;
    private Vector3 rotation;




    public void Start()
    {
        collisionBool = false;

        rb = GetComponent<Rigidbody>();
        objectCollider = GetComponent<Collider>();
        physicMaterial = objectCollider.material; 
        position = GetComponent<Transform>();

        mass = rb.mass;
        gravity = 9.8;
        normal = mass * gravity;
        theta = position.rotation.z; //negative moves rotation to left
        checkRotation();

    }

    public void Update()
    {
            

        
    }

    private void checkRotation()
    {
        if (rotation.z == 0)
        {
            Debug.Log("rotation of z is 0" + rotation.z);
            theta = -25f;
            position.Rotate(0, 0, theta);
            Debug.Log("rotation of z is -25" + rotation.z);
        }
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

    public double bankedFriction()
    {



        return 0.0; 
    }
}
