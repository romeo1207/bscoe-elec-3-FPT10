using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting1 : MonoBehaviour {
    public ParticleSystem _bullet;
    bool _delay;
	// Use this for initialization
	void Start () {
        _delay = false;
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(1);
        _delay = false;
    }

    void ProcessInput()
    {
        if (!_delay)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                _bullet.Emit(1);
                _delay = true;
                StartCoroutine("ExecuteAfterTime");
            }
        }
    }
}
