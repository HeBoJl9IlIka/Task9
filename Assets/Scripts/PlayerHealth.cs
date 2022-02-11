using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float _health = 100;

    public float Health => _health;

    public void TakeDamage(float damage)
    {
        _health += damage;
        CheckHealth();
    }

    public void TakeHealing(float healing)
    {
        _health += healing;
        CheckHealth();
    }

    private void CheckHealth()
    {
        if(_health > 100)
        {
            _health = 100;
        }    
        else if(_health < 0)
        {
            _health = 0;
        }
    }
}
