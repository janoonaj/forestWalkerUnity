using UnityEngine;
using System.Collections;

public class FourWaysMovement02 : MonoBehaviour {

	public float MoveSpeed=9f;
	public float JumpForce=7f;

	private bool wall_collision; //inicialmente es false; me parece rarisimo


	void OnCollisionEnter(Collision hit){

		if (hit.gameObject.tag == "wall") {
			wall_collision = true;
			Debug.Log (wall_collision);

		}

	}// end onCollisionEnter


	// Update is called once per frame
	void Update () {

	

			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.Translate (Vector3.left * MoveSpeed * Time.deltaTime);

			}

			if (Input.GetKey (KeyCode.RightArrow)) {
				transform.Translate (Vector3.right * MoveSpeed * Time.deltaTime);

			}

			if (Input.GetKey (KeyCode.DownArrow)) {
				transform.Translate (Vector3.back * MoveSpeed * Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.UpArrow)) {
				transform.Translate (Vector3.forward * MoveSpeed * Time.deltaTime);
			}



		if (wall_collision) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				GetComponent<Rigidbody> ().velocity = new Vector3 (0, JumpForce, 0);
				wall_collision = false;
			}
		}//end if



	} //end update



}// end class
