using UnityEngine;
using System.Collections;

public class player_fire01 : MonoBehaviour {

	public GameObject objeto; //objeto a instanciar, player_fire


	// Use this for initialization
	void Start () {

	
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 posicion= transform.position; //almacenar en un vector3 la posición del gameobject al cual está attachado el script


		if (Input.GetKeyDown (KeyCode.Space)) {
			//Instantiate (objeto, new Vector3 (transform.position, 0, 0), Quaternion.identity);
			Instantiate (objeto, posicion, Quaternion.identity);

		}

	
	}
}
