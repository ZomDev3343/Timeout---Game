using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


	public float moveSpeed;
	public float maxSpeed;
	
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void CheckMovements()
	{

		bool horizontal = Input.GetButton("Horizontal");
		bool vertical = Input.GetButton("Vertical");

		float horizontalFactor = Input.GetAxisRaw("Horizontal");
		float verticalFactor = Input.GetAxisRaw("Vertical");

		if (horizontal)
		{
			
		}
		
		

	}
}
