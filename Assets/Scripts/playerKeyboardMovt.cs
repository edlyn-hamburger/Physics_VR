using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerKeyboardMovt : MonoBehaviour
{
   public float speed = 2f; //speed of character movement
   public float forwrdBck;
   public float leftRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftRight = Input.GetAxis("Horizontal");
        forwrdBck = Input.GetAxis("Vertical");

        transform.Translate(leftRight * speed, 0, forwrdBck *  speed);
    }
}
