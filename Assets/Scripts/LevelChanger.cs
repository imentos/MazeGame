using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {
    public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetMouseButtonDown(0)) {
        //    animator.SetTrigger("out");
        //}

	}

    public void onFadeComplete() {
        SceneManager.LoadScene("Level1");
    }
}
