using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class frictionVelocity : MonoBehaviour
{
    /**private Rigidbody rb;
    private Transform position;
    private Collider colider;
    private PhysicMaterial physicMaterial;
    private Canvas canvas;
   

    private double gravity;
    private float mass;
    
    private double normal;**/

    public GameObject car;
    Mesh mesh;
    Vector3[] normals;
    int[] Mytriangles;
    Vector3[] trianlgeVecotrs;



    public void Start()
    {
        mesh = car.GetComponent<MeshFilter>().mesh;
        normals = mesh.normals;
        Mytriangles = mesh.triangles;
        trianlgeVecotrs = Mytriangles.;
       

        /**mass = rb.mass;
        gravity = 9.8;
        normal = mass * gravity;**/
    }

    public void Update()
    {
        Debug.Log(Mytriangles.);
        /**while (position.localPosition.z < 207f)
        {
            Debug.Log("Inside if statement");
            rb.AddForce(0f, 0f, 0f);
            Debug.Log("Frictional Force: " + dynamic_Friction() + " N"); //cheking fricitonal force
        }**/
    }

    /**public IEnumerator movingForce()
    {
        
            Debug.Log("Inside while statement");

            dynamic_Friction();
            //Debug.Log("Velocity of object: " + rb.velocity);

            yield return 0;// yield return waits for next frame
        

    }**/

    /**public IEnumerator removingFroce()
    {

    }**/

    /**public double dynamic_Friction()
    {
        /**
         * friction force is calculated 
         * f = mu * Normal Force 
         * mu = coeficient 
         * Normal Force = mass * gravity
         * 

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

        double staticFriction;
        double mu;

        mu = physicMaterial.staticFriction;
        staticFriction = mu * normal;

        return staticFriction; 
    }**/
}
