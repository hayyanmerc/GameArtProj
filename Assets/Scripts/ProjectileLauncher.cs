﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour {


	public GameObject projectile;
    private float coolDownTime = 5f; //this data will eventually come from load
    private float timeStamp;
	// Use this for initialization
	void Start () {
        timeStamp = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (timeStamp <= Time.time)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                GameObject bul = Instantiate(projectile, transform.position + new Vector3(1, 0, 0), Quaternion.identity) as GameObject;
                bul.transform.Translate(1, 0, 0);
                timeStamp = Time.time + coolDownTime;
            }
        }
		
	}
}
