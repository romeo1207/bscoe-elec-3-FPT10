using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDamage : MonoBehaviour {
    public int _EnemyHealth;
    public int _HalfLife;
    public bool _isDamaged;
    public bool _isDestroyed;
    public Slider _enemySlider;
    public ParticleSystem _Explosion;
    public ParticleSystem _Damaged;
    public ParticleSystem _EnemyBullet;
    public AudioSource _DestroySound;

	void Start () {
        _isDamaged = false;
        _enemySlider.maxValue = _EnemyHealth;
        _enemySlider.value = _EnemyHealth;
	}
	
	// Update is called once per frame
	void Update () {
        _enemySlider.value = _EnemyHealth;
	}

    private void OnParticleCollision(GameObject other)
    {
        if (!_isDestroyed) {
            //normal bullet
            if (other.gameObject.tag == "Player")
            {
                _EnemyHealth--;
            }

            if (_EnemyHealth <= _HalfLife && !_isDamaged)
            {
                _Damaged.Play();
                _isDamaged = true;
            }

            if (_EnemyHealth == 0)
            {
                Destroy(gameObject, 1f);
                _Explosion.Play();
                _EnemyBullet.Stop();
                _DestroySound.Play();
            }
            //BOMB
            if (other.gameObject.tag == "bomb")
            {
                Destroy(gameObject, 1f);
            }
        }
    }
}
