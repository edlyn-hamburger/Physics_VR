using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentComponents : MonoBehaviour
{

    public Collider parentCollider;

    public Collider getCollider()
    {
        parentCollider = GetComponent<Collider>();
        return parentCollider;
    }
    public void ParentMethod()
    {
        Debug.Log("Parent method called!");
    }


    
}
