using UnityEngine;
using System.Collections;

public class interpolator : MonoBehaviour {

	public Transform pointA;
	public Transform pointB;

	public float percent = 0;

	public float numberOfSeconds = 0.5f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		transform.position = Vector3.Lerp(pointA.position, pointB.position, percent);

	
		transform.rotation = Quaternion.Slerp (pointA.rotation, pointB.rotation, percent);



		percent = percent + Time.deltaTime / numberOfSeconds;		
		if (percent > 1) {
			percent = 0;
		}



		GetComponent<Renderer> ().material.color = Color.Lerp (Color.red, Color.blue, percent);




	}
}
