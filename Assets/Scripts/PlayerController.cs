using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    public float speed = 10f;

	// Use this for initialization
	void Start () {
        
        rb = GetComponent<Rigidbody>();
	   
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(horizontalInput * speed, -30f, verticalInput * speed);
	
	}
}
