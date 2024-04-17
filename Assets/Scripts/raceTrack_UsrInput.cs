using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raceTrack_UsrInput : MonoBehaviour
{
    //public string input;
    //public GameObject onStartButton;
    //public Animator animator;
    public Button[] buttons; 

    // Start is called before the first frame update
    void Start()
    {
        buttons = gameObject.GetComponentsInChildren<Button>();
        //animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < buttons.Length; i++)
        {
           // if ();
        }
        
    }

 
}
