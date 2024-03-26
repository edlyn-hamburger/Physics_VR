using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabinetTransform : MonoBehaviour
{
    private GameObject cabinetDrawer;
    private Vector3 cabinetDrawerPosition; //variable for position of drawer cabinet

    void Awake()
    {
        cabinetDrawer = GameObject.FindWithTag("drawer"); //get drawer
        cabinetDrawerPosition = gameObject.transform.position; // get drawer position
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(cabinetDrawerPosition); //print cabinet drawer position

        if (Input.GetKey(KeyCode.Mouse0))
        {
           
            gameObject.transform.Translate(0, 0, 1);
            Debug.Log(cabinetDrawerPosition);

        }
    }
}
