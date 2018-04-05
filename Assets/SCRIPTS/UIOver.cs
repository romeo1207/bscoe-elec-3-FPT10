using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIOver : MonoBehaviour {
    public static int _levelCounter;
	// Use this for initialization
	void Start () {
        _levelCounter = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Splash1");
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            if(_levelCounter == 1)
            {
                SceneManager.LoadScene("Level1");
            }
            else if(_levelCounter == 2)
            {
                SceneManager.LoadScene("level2");
            }
            else if(_levelCounter == 3)
            {
                SceneManager.LoadScene("level3");
            }
            else if(_levelCounter == 4)
            {
                SceneManager.LoadScene("level4");
            }
            else if (_levelCounter == 5)
            {
                SceneManager.LoadScene("level5");
            }
        }
	}
}
