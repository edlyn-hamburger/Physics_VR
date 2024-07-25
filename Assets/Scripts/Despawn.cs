using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawning : MonoBehaviour
{
    public GameObject targetObject;

    //bool despawnPress = false;

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            DespawnObject();
        }

    }

    private void DespawnObject()
    {
        if (targetObject != null)
        {
            Destroy(targetObject);
            targetObject = null;
        }
    }


}