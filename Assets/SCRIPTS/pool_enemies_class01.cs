using UnityEngine;
using System.Collections;

public class pool_enemies_class01 : MonoBehaviour {

	public GameObject player;

	public Vector3 offset;

	// Use this for initialization
	void Start () {
	
		offset = transform.position - player.transform.position;

	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
		transform.position = player.transform.position + offset;
	}
}
