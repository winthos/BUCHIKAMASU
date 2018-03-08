using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchSoundController : MonoBehaviour 
{

    public AudioSource JabSource = null;

    public AudioSource StraightSource = null;

    public AudioSource LeftHookSource = null;

    public AudioSource RightHookSource = null;

    public AudioSource LeftUpperSource = null;

    public AudioSource RightUpperSource = null;

	// Use this for initialization
	void Start () 
    {
        //MyAudioSource = gameObject.GetComponent<AudioSource>();
	}

	void Update () 
    {
		
	}

    public void PlayJab()
    {
        JabSource.pitch = Random.Range(0.9f, 1.2f);
        //vibrate controller here
        JabSource.Play();
    }

    public void PlayStraight()
    {
        StraightSource.pitch = Random.Range(0.9f, 1.2f);

        StraightSource.Play();
    }

    public void PlayLeftHook()
    {
        LeftHookSource.pitch = Random.Range(1.1f, 1.5f);

        LeftHookSource.Play();
    }

    public void PlayRightHook()
    {
        RightHookSource.pitch = Random.Range(0.8f, 1.1f);

        RightHookSource.Play();
    }

    public void PlayLeftUpper()
    {
        LeftUpperSource.pitch = Random.Range(0.8f, 1.1f);

        LeftUpperSource.Play();
    }

    public void PlayRightUpper()
    {
        RightUpperSource.pitch = Random.Range(1.1f, 1.4f);

        RightUpperSource.Play();
    }
}
