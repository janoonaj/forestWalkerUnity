using UnityEngine;
using System.Collections;

public class FourWaysMovement_FPS01 : MonoBehaviour {
	
	public float MoveSpeed=2f;
	public float JumpForce=7f;
	
	private bool grounded; //inicialmente es false; me parece rarisimo
	
	
	void OnCollisionEnter(Collision hit){
		
		if (hit.gameObject.tag == "wall") {
			grounded = true;
			Debug.Log (grounded);
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
		
		if (grounded) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				GetComponent<Rigidbody> ().velocity = new Vector3 (0, JumpForce, 0);
				grounded = false;
			}
		}//end if
		
		
		
	} //end update
	
	
	
}// end class
