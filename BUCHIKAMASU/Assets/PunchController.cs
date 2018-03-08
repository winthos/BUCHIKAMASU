using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchController : MonoBehaviour 
{
    Animator MyAnimator = null;

    public bool isAxisInUse = false;
    public bool isAxisInUse_Straight = false;

	// Use this for initialization
	void Start () 
    {
        MyAnimator = gameObject.GetComponent<Animator>();
		
	}

    public void TurnOffAxisInUse()
    {
        isAxisInUse = false;
    }
	
	// Update is called once per frame
	void Update () 
    {
        //print(Input.GetAxisRaw("RightStickVertical"));

		if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.F))
        {
            MyAnimator.SetTrigger("Jab");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.J))
        {
            MyAnimator.SetTrigger("Straight");

        }

        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.D))
        {
            MyAnimator.SetTrigger("LeftHook");

        }


        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.K))
        {
            MyAnimator.SetTrigger("RightHook");

        }

        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.S))
        {
            MyAnimator.SetTrigger("LeftUpper");

        }

        if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.L))
        {
            MyAnimator.SetTrigger("RightUpper");

        }

        //////////////CONTROLLER//////////////////

        if (Input.GetAxis("LeftStickVertical") <= -0.5)
        {
            if (isAxisInUse == false)
            {
                MyAnimator.SetTrigger("Jab");
                isAxisInUse = true;
            }
        }

        if (Input.GetAxis("LeftStickVertical") >= -0.5)
        {
            isAxisInUse = false;
        }

        //////

        if (Input.GetAxis("RightStickVertical") <= -0.5)
        {
            if (isAxisInUse_Straight == false)
            {
                isAxisInUse_Straight = true;
               // print("buh");
                MyAnimator.SetTrigger("Straight");
                
            }
        }

        if (Input.GetAxis("RightStickVertical") >= -0.5)
        {
            isAxisInUse_Straight = false;
        }
    }
}
