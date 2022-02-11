using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerInterface : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _duration;

    public void ShowHealthBar(float value)
    {
        _slider.DOValue(_slider.value + value, _duration);
    }
}
