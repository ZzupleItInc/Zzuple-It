﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisible_script : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GetComponent<SpriteRenderer>().enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
