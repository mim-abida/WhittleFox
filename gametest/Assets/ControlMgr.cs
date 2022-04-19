using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMgr : MonoBehaviour
{

    public static ControlMgr inst;
    private void Awake()
    {
        inst = this;
    }
    // Start is called before the first frame update

    void Start()
    {
        
    }

    public float deltaVelocity = 5;
    // Update is called once per frame
    void Update()
    {
        //controls

        //left right movement

       


        //space for movement
        if (Input.GetKeyUp(KeyCode.Space))
        {

        }
        //s for crouch? maybe

        //just for exiting the game 
       /* if (Input.GetKey("escape"))
        {
            Application.Quit;
        }*/
    }
}
