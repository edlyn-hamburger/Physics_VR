using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raceTrack_UsrInput : MonoBehaviour
{
    public string input;
    public GameObject onStartButton;
    public Animator animator; 

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void speedInput (string s)
    {
        input = s;
    }
}
