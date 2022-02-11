using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(Image))]
public class ButtonAnimation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private float _duration = 0.5f;
    [SerializeField] private string _targetText;
    [SerializeField] private Color _targerColor;
    [SerializeField] private UnityEvent _entered;
    [SerializeField] private UnityEvent _released;

    private string _defaultText;
    private RectTransform _rectTransform;
    private Vector2 _defaultSize;
    private Color _defaultColor;
    private Image _image;
    private Text _text;

    private void Awake()
    {
        _text = GetComponentInChildren<Text>();
        _rectTransform = GetComponent<RectTransform>();
        _image = GetComponent<Image>();

        _defaultText = _text.text;
        _defaultSize = _rectTransform.sizeDelta;
        _defaultColor = _text.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _entered?.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _released?.Invoke();
    }

    public void ChangeText(bool input)
    {
        string output = input ? _targetText : _defaultText;
        _text.DOText(output, _duration, true, ScrambleMode.All);
    }

    public void ChangeTextColor(bool input)
    {
        Color output = input ? _targerColor : _defaultColor;
        _text.DOColor(output, _duration);
    }

    public void ChangeButtonSize(bool input)
    {
        float number = 1.05f;
        Vector2 output = input ? _defaultSize * number : _defaultSize;
        _rectTransform.DOSizeDelta(output, _duration);
    }

    public void ChangeButtonColor(bool input)
    {
        Color output = input ? _targerColor : _defaultColor;
        _image.DOColor(output, _duration);
    }
}
