using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Objective3 : MonoBehaviour {

    public Text Objective;
	void Start () {
        Objective = GetComponent<Text>();        
    }
	
	// Update is called once per frame
	void Update () {

        if (GameObject.FindWithTag("Enemy") == null)
        {
            SceneManager.LoadScene("Splash1");
        }
        else if (PlayerDamage._isDestroyed)
        {
            SceneManager.LoadScene("GameOverScene");
        }

       // if(UIOver._levelCounter == 1)
        //{

//        }
    }
        
}
