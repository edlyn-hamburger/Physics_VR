using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabinetTransform : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            gameObject.transform.Translate(0, 0, 1);
        }
    }
}
