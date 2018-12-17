using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour {
    public float speed = 10f;
    public Vector2 moving = new Vector2();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //var forceX = 0f;
        //var forceY = 0f;
        
        //if (Input.GetKey("right"))
        //{
        //    moving.x = 1;
        //}
        //else if (Input.GetKey("left"))
        //{
        //    moving.x = -1;
        //}

        //if (Input.GetKey("up"))
        //{
        //    moving.y = 1;
        //}
        //else if (Input.GetKey("down"))
        //{
        //    moving.y = -1;
        //}

        //forceX = speed * moving.x;
        //forceY = speed * moving.y;

        //GetComponent<Rigidbody2D>().AddForce(new Vector2(forceX, forceY));

        ////GetComponent<Rigidbody2D>().transform.position = 

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        GetComponent<Rigidbody2D>().AddForce(movement * speed);
	}
}
