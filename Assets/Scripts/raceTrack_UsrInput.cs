using UnityEngine;
using UnityEngine.UI;

public class raceTrack_UsrInput : MonoBehaviour
{
    //public string input;
    //public GameObject onStartButton;
    public Animator animator;
    //public Button[] buttons; 

    // Start is called before the first frame update
    void Start()
    {
        //buttons = gameObject.GetComponentsInChildren<Button>();
         
        animator = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    public void startAnimation()
    {
        /**bool start = Input.GetButton("START");
        for (int i = 0; i < buttons.Length; i++)
        {
           if (start)
            {
                Debug.Log("Start was pressed");
            }
        }**/ 

       if(Input.GetMouseButtonDown(0))
        {
            animator.Play("rackTrackAnimation");
        }
        
    }

    public void stopAnimation()
    {
        if(Input.GetMouseButtonDown(0))
        {
            animator.enabled = false;
        }
    }

 
}
