using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour {

    Rigidbody rb;

    public Text countText;
    public Text winText;
    public Text myTime;
    int count;

    DateTime curr;
    public float speed;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

        count = 0;
        countText.text = "分數";
        winText.text = "";
        myTime.text = "10";

        curr = DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // transform.Translate(x, 0, z);

        rb.AddForce(new Vector3(x, 0, z)*speed);

        TimeSpan ts = DateTime.Now - curr;

        if (winText.text != "YOU WIN!")
        {
            if (ts.Seconds < 55)
            {
                myTime.text = (55 - ts.Seconds).ToString() + ":" + (1000 - ts.Milliseconds).ToString();
            }
            else
            {
                    myTime.text = "0";
                    winText.text = "YOU LOSE!";
            }
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pick up"))
        {
            other.gameObject.SetActive(false);
            count++;
            countText.text = "分數:" + count.ToString();

            if (count == 5 && winText.text != "YOU LOSE!")
            {
                winText.text = "YOU WIN!";
            }
        }

    }	
}
