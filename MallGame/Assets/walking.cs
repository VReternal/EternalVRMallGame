using UnityEngine;
using System.Collections;

public class walking : MonoBehaviour {
	private Rigidbody rbody;
	private Animator anim;
	public double speed_f;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		rbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Debug.Log (rbody.velocity.magnitude);
		/*
		speed_f = rbody.velocity.magnitude;
		anim.SetFloat ("Speed_f", speed_f);
		Debug.Log ("Speed_f: " + anim.GetFloat ("Speed_f"));
		Debug.Log ("speed_f11: " + speed_f);
		*/
	}
}
