using UnityEngine;
using System.Collections;

public class Wall_fall_test01 : MonoBehaviour
{

	// Use this for initialization
	public float fallVelocity=0.001f;
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate(Vector3.down*fallVelocity);
	
	}
}

