using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchController : MonoBehaviour 
{
    Animator MyAnimator = null;

    public bool isAxisInUse = false;
    public bool isAxisInUse_Straight = false;

    public bool isAxisInUse_LeftHook = false;
    public bool LeftHookAct1 = false;

    public bool isAxisInUse_RightHook = false;
    public bool RightHookAct1 = false;

    public bool isAxisInUse_LeftUpper = false;
    public bool LeftUpperAct1 = false;

    public bool isAxisInUse_RightUpper = false;
    public bool RightUpperAct1 = false;

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
    void Update()
    {
        //print(Input.GetAxisRaw("RightStickHorizontal"));

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.F))
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

        //////////////CONTROLLER NONSENSE//////////////////

        //JAB!//
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

        ////STRAIGHTO//
        if (Input.GetAxis("RightStickVertical") <= -0.5)
        {
            if (isAxisInUse_Straight == false)
            {
                isAxisInUse_Straight = true;
                MyAnimator.SetTrigger("Straight");

            }
        }

        if (Input.GetAxis("RightStickVertical") >= -0.5)
        {
            isAxisInUse_Straight = false;
        }

        //LEFT HOOK/////-1 on left to 1 on right
        if (Input.GetAxis("LeftStickHorizontal") <= -0.5)
        {
            if(isAxisInUse_LeftHook == false)
            {
               // print("buh");
                isAxisInUse_LeftHook = true;
                LeftHookAct1 = true;
                StartCoroutine("LeftHookCountDown");
               
            }
        }

        if(Input.GetAxis("LeftStickHorizontal") >= 0.5 && LeftHookAct1 == true)
        {
            LeftHookAct1 = false;
            MyAnimator.SetTrigger("LeftHook");

        }

        //RIGHT HOOOOK////
        if (Input.GetAxis("RightStickHorizontal") >= 0.5)
        {
            if (isAxisInUse_RightHook == false)
            {
                // print("buh");
                isAxisInUse_RightHook = true;
                RightHookAct1 = true;
                StartCoroutine("RightHookCountDown");
            }
        }

        if (Input.GetAxis("RightStickHorizontal") <= -0.5 && RightHookAct1 == true)
        {
            RightHookAct1 = false;
            MyAnimator.SetTrigger("RightHook");
        }

        ////LEFT UPPPAAAAAA/////
        if (Input.GetAxis("LeftStickVertical") >= 0.5)
        {
            if (isAxisInUse_LeftUpper == false)
            {
                isAxisInUse_LeftUpper = true;
                LeftUpperAct1 = true;
                StartCoroutine("LeftUpperCountDown");
            }
        }

        if (Input.GetAxis("LeftStickVertical") <= -0.5 && LeftUpperAct1 == true)
        {
            LeftUpperAct1 = false;
            MyAnimator.SetTrigger("LeftUpper");
        }


        ////RIGHT UPPPAAAAA/////

        if (Input.GetAxis("RightStickVertical") >= 0.5)
        {
            if (isAxisInUse_RightUpper == false)
            {
                isAxisInUse_RightUpper = true;
                RightUpperAct1 = true;
                StartCoroutine("RightUpperCountDown");
            }
        }

        if (Input.GetAxis("RightStickVertical") <= -0.5 && RightUpperAct1 == true)
        {
            RightUpperAct1 = false;
            MyAnimator.SetTrigger("RightUpper");
        }

    }

    IEnumerator LeftHookCountDown()
    {
        yield return new WaitForSeconds(0.05f);

        LeftHookAct1 = false;
        isAxisInUse_LeftHook = false;
    }

    IEnumerator RightHookCountDown()
    {
        yield return new WaitForSeconds(0.05f);

        RightHookAct1 = false;
        isAxisInUse_RightHook = false;
    }

    IEnumerator LeftUpperCountDown()
    {
        yield return new WaitForSeconds(0.15f);

        LeftUpperAct1 = false;
        isAxisInUse_LeftUpper = false;
    }

    IEnumerator RightUpperCountDown()
    {
        yield return new WaitForSeconds(0.15f);

        RightUpperAct1 = false;
        isAxisInUse_RightUpper = false;
    }
}
