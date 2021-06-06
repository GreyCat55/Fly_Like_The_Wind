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

	private void FixedUpdate()
	{
		if (WindZone != null && InWindZone) //&& WindZone.GetComponent<WindArea>().isLeftClickHeld == true
		{
			rb.drag = 1;
			rb.AddForce(WindZone.GetComponent<WindArea>().Direction * WindZone.GetComponent<WindArea>().Strength);

			if (this.gameObject.tag == "PlayerBird")
			{
				float s = Mathf.Floor(gameObject.GetComponent<Rigidbody>().velocity.magnitude * 10);
				GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>().AddScore(Mathf.RoundToInt(s));
			}
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
			WindZone = coll.gameObject; //coll.gameobject is the wind prefab's rigidbody 
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
