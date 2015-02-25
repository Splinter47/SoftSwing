using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
	
	private Vector3 speed = new Vector3(3, 0, 0);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
    void FixedUpdate() {
        rigidbody.MovePosition(rigidbody.position + speed * Time.deltaTime);
    }
}
