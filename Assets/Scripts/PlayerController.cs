using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Collider p_Collider;
    private Vector3 p_Vector;
    parentComponents parentParts; 
    public void Start()
    {
        p_Collider = GetComponent<Collider>();
        p_Vector = p_Collider.bounds.center;
    }

    void outPutData()
    {
        Debug.Log("this is the parent object collider bounds min: " +  p_Vector);
    }
}