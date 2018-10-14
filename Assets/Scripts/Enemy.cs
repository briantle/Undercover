﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour 
{
	public float health;

	private Rigidbody[] bodies;
	// Use this for initialization
	void Start () 
	{
		health = 100;
		bodies = GetComponentsInChildren<Rigidbody> ();
		SetKinematic (true);
	}

	void SetKinematic(bool isKinematic)
	{
		foreach (Rigidbody bodyPart in bodies)
			bodyPart.isKinematic = isKinematic;
	}

	public void Dead(){
		SetKinematic (false);
		enabled = false;
		AI aiScript = gameObject.GetComponent<AI> ();
		if (aiScript)
			aiScript.enabled = false;
	}
}
