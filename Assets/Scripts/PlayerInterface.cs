using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerInterface : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _duration;
    [SerializeField] private PlayerHealth _playerHealth;

    public void ShowInfo()
    {
        _slider.DOValue(_playerHealth.Health, _duration);
    }
}
