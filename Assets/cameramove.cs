﻿using UnityEngine;

public class cameramove : MonoBehaviour {


    public Transform player;
    public Vector3 offset;
	// Use this for initialization
	void Start () {

        offset = transform.position - player.position;
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = player.position + offset;
		
	}
}
