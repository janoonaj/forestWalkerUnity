using UnityEngine;
using System.Collections;

public class Forward_auto01 : MonoBehaviour
{

	// Use this for initialization
	public float ForwardSpeed=1f;
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (Vector3.forward * ForwardSpeed * Time.deltaTime);

	
	}
}

