using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.ProBuilder;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Transform position;
    private Collider colider;
    private PhysicMaterial physicMaterial;
    private Canvas canvas;
   

    private double gravity;
    private float mass;
    private double roadFriction;
    private double normal;
    private double rbAddFroce;
    private double rbRemoveForce;
    private inputHandler userInput;
    private string nameTest; //delete later 

    public void Start()
    {
        //Getting Components
        rb = GetComponent<Rigidbody>();
        position = GetComponent<Transform>();
        colider = GetComponent<Collider>();
        //canvas = GetComponentInParent<canvasConnecter>();


        /** tring to get input from canvas but canvas is an object in the same hierarchy 
         * as object that will handle velocity not component of object. Can assign canvas 
         * as component of the track prefab, which is the parent of object handling velocity
         * and maybe get input from there. Input is handled by TMP but rn I'm just trying to get 
         * canvas object 
         * 
         * Now that I think about maybe I should develop the track prefab more with built in TMP components
         * also need to look into event system more as this seems to handle events like this but I need input 
         * from user. 
         * 
         * input could be string, or could be movement/trigger from controller. I need to think about how input
         * will be handled**/

        //Initializing variables
        physicMaterial = colider.material;
        mass = rb.mass;
        gravity = 9.8;
        normal = mass * gravity;
        roadFriction = 0.8; //hardcoding static friction of road
        nameTest = canvas.name;// delete later 

        userInput = new inputHandler(); 

        
        
        
    }

    public void Update()
    {
        Debug.Log("Canvas in name: " + nameTest);//delete later 
        
        while (position.localPosition.z < 207f)
        {
            Debug.Log("Inside if statement");
            rb.AddForce(0f, 0f, 0f);
            Debug.Log("Frictional Force: " + dynamic_Friction() + " N"); //cheking fricitonal force
        }
        

        

    }

    public IEnumerator movingForce()
    {
        
            Debug.Log("Inside while statement");

            dynamic_Friction();
            //Debug.Log("Velocity of object: " + rb.velocity);

            yield return 0;// yield return waits for next frame
        

    }

    /**public IEnumerator removingFroce()
    {

    }**/

    public double dynamic_Friction()
    {
        /**
         * friction force is calculated 
         * f = mu * Normal Force 
         * mu = coeficient 
         * Normal Force = mass * gravity
         * **/

        double dynamicFriction;
        double mu;

        mu = physicMaterial.dynamicFriction; 
        dynamicFriction = mu * normal;

        return dynamicFriction;

    }

    public double static_Friction ()
    {
        /**
         * same as dynamic **/

        double staticFriction;
        double mu;

        mu = physicMaterial.staticFriction;
        staticFriction = mu * normal;

        return staticFriction; 
    }

    
 }
