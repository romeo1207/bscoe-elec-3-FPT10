using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBuilding : MonoBehaviour {

    public int _EnemyBuildingHealth;
    public int _EnemyBuildingHalfLife;
    public ParticleSystem _ParticleDamaged;
    public ParticleSystem _ParticleDestroyed;
    public Slider _BuildingSlider;
    public AudioSource _SFXBoom;
    bool _isDamaged;
    bool _isDestroyed;
        

	// Use this for initialization
	void Start () {
        _isDamaged = false;
        _isDestroyed = false;
        _BuildingSlider.maxValue = _EnemyBuildingHealth;
	}
	
	// Update is called once per frame
	void Update () {
        _BuildingSlider.value = _EnemyBuildingHealth;
	}

    public void OnParticleCollision(GameObject other)
    {
        if (!_isDestroyed)
        {
            //normal bullet
            if(other.gameObject.tag == "Player")
            {
                _EnemyBuildingHealth--;
            }
            if(_EnemyBuildingHealth <= _EnemyBuildingHalfLife && !_isDamaged)
            {
                _ParticleDamaged.Play();
                _isDamaged = true;
            }
            if(_EnemyBuildingHealth <= 0)
            {
                _ParticleDestroyed.Play();
                _SFXBoom.Play();
                Destroy(gameObject, 3f);
                _isDestroyed = true;
            }
        }
    }
}
