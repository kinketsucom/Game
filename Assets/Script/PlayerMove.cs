using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	private Animator anim;

	private bool move_bool;
	private float speed= 100;

	private GameObject Man;
	private Rigidbody rb;




	void Start () {
		anim = GetComponent<Animator>();
		Man = GameObject.Find ("Player");
		rb = Man.GetComponent<Rigidbody> ();
	}

	void Update ()
	{
		move_bool = false;
		if(Input.GetKey(KeyCode.UpArrow)){
			anim.SetBool ("walk_bool", true);
			rb.AddForce (0, 0, speed);
			Man.transform.localRotation = Quaternion.LookRotation (Vector3.forward);
			move_bool = true;
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			anim.SetBool ("walk_bool", true);
			rb.AddForce (speed,0,0);
			Man.transform.localRotation = Quaternion.LookRotation (Vector3.right);
			move_bool = true;
		}
	
		if(Input.GetKey(KeyCode.LeftArrow)){
			anim.SetBool ("walk_bool", true);
			rb.AddForce (-speed,0,0);
			Man.transform.localRotation = Quaternion.LookRotation (-Vector3.left);
			move_bool = true;
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			anim.SetBool ("walk_bool", true);
			rb.AddForce (0, 0, -speed);
			Man.transform.localRotation = Quaternion.LookRotation (-Vector3.forward);
			move_bool = true;
		}
	
		if(!move_bool){
			anim.SetBool ("walk_bool", false);
		}
	}
}