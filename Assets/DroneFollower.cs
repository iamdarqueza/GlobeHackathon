using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneFollower : MonoBehaviour {

	[SerializeField] Transform droneTransform;
	[SerializeField] float maxDistance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector2.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(droneTransform.position.x, droneTransform.position.z)) > maxDistance)
		{
			Vector2 newPosition = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.z), new Vector2(droneTransform.position.x, droneTransform.position.z), 0.02f);
			Debug.Log (newPosition);
			transform.position = new Vector3(newPosition.x, transform.position.y, newPosition.y);
		}

//		transform.position = Vector3.MoveTowards (transform.position, droneTransform.position, .5f);
	}
}
