using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerInterface : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private Slider _slider;
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private float _duration;

    public void ShowHealthBar()
    {
        _slider.DOValue(_playerHealth.Health, _duration);
        _text.DOText(_playerHealth.Health.ToString(), _duration, true, ScrambleMode.Numerals);
    }
}
