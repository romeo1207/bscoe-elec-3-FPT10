using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerDamage : MonoBehaviour {

    public ParticleSystem _ParticleDamaged;
    public ParticleSystem _ParticleDestroyed;
    public Slider _PlayerHealthWheel;
    public AudioSource _SFXExplotion;
    public int _PlayerHealth;
    public int _PlayerHalfLife;
    public bool _isDamaged;
    public static bool _isDestroyed;

	// Use this for initialization
	void Start () {
        _PlayerHealth = 10;
        _PlayerHealthWheel.maxValue = _PlayerHealth;
        _isDamaged = false;
        _isDestroyed = false;        
        _ParticleDamaged.Stop();
        _ParticleDestroyed.Stop();
    }
	
	// Update is called once per frame
	void Update () {
        _PlayerHealthWheel.value = _PlayerHealth;
	}

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(2);
        _isDestroyed = true;
    }

    public void OnParticleCollision(GameObject other)
    {
        if (!_isDestroyed)
        {
            //normal enemy bullet
            if (other.gameObject.tag == "Enemy")
            {
                _PlayerHealth--;
            }
            //barrel explotion
            if (other.gameObject.tag == "barrel")
            {
                _PlayerHealth = 0;
            }
            //play damaged particle
            if (_PlayerHealth <= _PlayerHalfLife && !_isDamaged)
            {
                _ParticleDamaged.Play();
                _isDamaged = true;
            }
            //when player is destroyed
            if (_PlayerHealth == 0 && !_isDestroyed)
            {
                Destroy(GameObject.FindWithTag("Player"), 1f);
                _SFXExplotion.Play();
                _ParticleDestroyed.Play();
                
                StartCoroutine("ExecuteAfterTime");
            }
        }
    }
}
