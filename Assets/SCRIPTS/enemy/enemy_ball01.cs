using UnityEngine;
using System.Collections;

public class enemy_ball01 : MonoBehaviour {

	// Use this for initialization
	public GameObject explosion;  // esto es una chapuza, la explosion se debería controlar desde la detección de colisión de la bala

	public float speed=6f;

	public float sssss = 4f;

	public float fuerza = 2f;

		// Use this for initialization
	void OnCollisionEnter(Collision hit){
		if (hit.gameObject.tag == "pool") {
			Destroy (gameObject);

		} //end pool

		if (hit.gameObject.tag == "player_fire") {
			Destroy (hit.gameObject);

		ContactPoint contact = hit.contacts[0];
			Vector3 pos = contact.point;
			Instantiate (explosion, pos, Quaternion.identity);

				
			fuerza = fuerza - 1;
			if (fuerza < 1) {
				Destroy (gameObject);


			} 


		}//end player_fire

	} // end collision





	/*void OnTriggerEnter(Collider hit){
		if (hit.gameObject.tag == "pool") {
			Destroy (hit.gameObject);
			Debug.Log ("toca");
		}

	}*/

		// Update is called once per frame
		void Update ()
		{
			transform.Translate (Vector3.back * speed * Time.deltaTime);

		}
	}

