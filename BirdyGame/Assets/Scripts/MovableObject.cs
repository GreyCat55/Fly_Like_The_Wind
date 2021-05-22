using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour
{

	//public float LifeTime = 10f;
	public bool InWindZone = false;
	private GameObject WindZone;

	Rigidbody rb;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void FixedUpdate()
	{
		if (WindZone != null && InWindZone) //&& WindZone.GetComponent<WindArea>().isLeftClickHeld == true
		{
			rb.drag = 1;
			rb.AddForce(WindZone.GetComponent<WindArea>().Direction * WindZone.GetComponent<WindArea>().Strength);
		}
		else
		{
			rb.drag = 2; //adding more drag to an object decelerates it if a force is pushing it
		}
	}

	void OnTriggerEnter(Collider coll)
	{
		if (coll.gameObject.tag == "WindArea")
		{
			WindZone = coll.gameObject; //coll.gameobject is the object colliding with the ball (which is the wind!) 
			InWindZone = true;
		}
	}

	void OnTriggerExit(Collider coll)
	{
		if (coll.gameObject.tag == "WindArea")
		{
			//WindZone = null;
			InWindZone = false;
		}
	}
}
