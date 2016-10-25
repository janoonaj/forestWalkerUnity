using UnityEngine;
using System.Collections;

public class Boolean_movement_test01 : MonoBehaviour {
	
	public float MoveSpeed=0.5f;
	private int _direccion=0; //set a 0 para que se quede parada de inicio
	private bool _canStart=false;
	
	private bool grounded; //inicialmente es false; me parece rarisimo
	
	
	void OnCollisionEnter(Collision hit){
		
		if (hit.gameObject.tag == "wall") {
			grounded = true;

		}
		
	}// end onCollisionEnter
	
	
	// Update is called once per frame
	void Update () {
		
		if (_direccion==1) {
			transform.Translate (Vector3.right * MoveSpeed * Time.deltaTime);
		} else if(_direccion==-1) {
			transform.Translate (Vector3.left * MoveSpeed * Time.deltaTime);
		}


		if (grounded) {
			if (Input.GetKeyDown (KeyCode.Space)) {
					
			
				if (!_canStart) {
					_canStart = true;
					_direccion=1;

				}
			
					if (_direccion == 1) {
						_direccion = -1;
					} else if (_direccion == -1) {
						_direccion = 1;
					}


				}
			}//end if

		
		
		
	} //end update


	
	
}// end class







