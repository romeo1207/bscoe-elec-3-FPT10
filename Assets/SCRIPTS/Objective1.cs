using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objective1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindWithTag("Enemy") == null)
        {
            SceneManager.LoadScene("level2");
        }
        else if (PlayerDamage._isDestroyed)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
