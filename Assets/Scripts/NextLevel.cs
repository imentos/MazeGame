﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
    public LevelChanger levelChanger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "Player")
        {
            //SceneManager.LoadScene("Level1");
            levelChanger.animator.SetTrigger("out");
        }
	}
}
