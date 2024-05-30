using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Transform position;
    private Collider colider;
    private PhysicMaterial physicMaterial;

    private double gravity;
    private float mass;
    private double roadFriction;

    public void Start()
    {
        //Getting Components
        rb = GetComponent<Rigidbody>();
        position = GetComponent<Transform>();
        colider = GetComponent<Collider>();
        
        //Initializing variables
        physicMaterial = colider.material;
        mass = rb.mass;
        gravity = 9.8;
        roadFriction = 0.8; //hardcoding statis friction of road

        StartCoroutine(movingForce());//calling moving routine
        
    }

    public void Update()
    {


        
        if (position.localPosition.z < 207f)
        {
            Debug.Log("Inside if statement");
            rb.AddForce(0f, 0f, 0f);
            Debug.Log("Frictional Force: " + dynamic_Friction() + " N"); //cheking fricitonal force
        }
        else
        {
            rb.AddForce(0f, 0f, 5f);
            Debug.Log("Inside else statment, local position: " + position.localPosition.z);
            //Debug.Log("Frictional Force: " + dynamic_Friction() + " N"); //cheking fricitonal force
        }

        

    }

    public IEnumerator movingForce()
    {
        while (position.localPosition.z > 207f) //while object is not at end position
        {
            Debug.Log("Inside while statement");
            rb.velocity = new Vector3(0f, 0f, 5f); //put velocity on object



            //Debug.Log("Velocity of object: " + rb.velocity);

            yield return 0;// yield return waits for next frame
        }

    }

    public double dynamic_Friction()
    {
        /**
         * friction force is calculated 
         * f = mu * Normal Force 
         * mu = coeficient 
         * Normal Force = mass * gravity
         * **/

        double dynamicFriction;
        double normal;
        double mu;

        normal = mass * gravity;
        mu = physicMaterial.dynamicFriction;

        dynamicFriction = mu * normal;

        return dynamicFriction;

    }

    /**public double static_Friction ()
    {

    }**/

    
 }
