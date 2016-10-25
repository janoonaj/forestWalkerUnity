using UnityEngine;
using System.Collections;

public class player_fire_class01 : MonoBehaviour {

	// Use this for initialization
	public float ForwardSpeed=1f;

	void Start() 
	{
		Destroy (gameObject, 2f); // pool para destruir balas una vez salgan fuera de campo
	}


	/*void OnCollisionEnter(Collision hit){

		if (hit.gameObject.tag == "enemy") {
			enemy_ball01 enemigo = hit.gameObject.GetComponent<enemy_ball01> (); // hardcode

			Debug.Log ("fuerza " + enemigo.fuerza);

			// PROBLEMA: se supone que con esta función debería acceder a la fuerza de cada enemigo, cuyo script variará
			// de nombre. No sé cómo hacerlo sin hardcodear.
			// Lo único que se me ocurre sería hacer una clase común Fuerza para compartir entre todos, o bien,
			// detectar la colisión desde cada enemigo y desde aquí controlar la destruccion de cada bala
		}
	}*/



	// Update is called once per frame
	void Update ()
	{
		transform.Translate (Vector3.forward * ForwardSpeed * Time.deltaTime);


	}
}
