using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int _health = 100;

    public int Health => _health;

    public void TakeDamage(int damage)
    {
        if(_health > 0)
        {
            _health += damage;
        }
        else
        {
            _health = 0;
        }
    }

    public void TakeHealing(int healing)
    {
        if (_health < 100)
        {
            _health += healing;
        }
        else
        {
            _health = 100;
        }
    }
}
