using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchController : MonoBehaviour 
{
    Animator MyAnimator = null;

	// Use this for initialization
	void Start () 
    {
        MyAnimator = gameObject.GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            MyAnimator.SetTrigger("Jab");

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MyAnimator.SetTrigger("Straight");

        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            MyAnimator.SetTrigger("LeftHook");

        }


        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            MyAnimator.SetTrigger("RightHook");

        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            MyAnimator.SetTrigger("LeftUpper");

        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            MyAnimator.SetTrigger("RightUpper");

        }
    }
}
