﻿using UnityEngine;
using System.Collections;


public class Projectile : MonoBehaviour {
	public int damage = 1;


	// Use this for initialization
	void OnCollisionEnter(){
		Destroy (gameObject);
	}
	void Start () {
		Destroy (gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0.1f, 0, 0);
	}
}
