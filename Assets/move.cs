using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    Rigidbody rb;
    public float speed;
	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // transform.Translate(x, 0, z);

        rb.AddForce(new Vector3(x, 0, z)*speed);
    }

    void OnTriggerEnter(Collider other)
    {
            other.gameObject.SetActive(false);

    }	
}
