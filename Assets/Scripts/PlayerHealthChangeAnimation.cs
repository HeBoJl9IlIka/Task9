using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]
public class PlayerHealthChangeAnimation : MonoBehaviour
{
    private Color _default;
    private Color _damage = Color.red;
    private Color _healing = Color.green;
    private float _duration = 0.2f;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _default = _spriteRenderer.color;
    }

    public void ChangeColorOnDamage()
    {
        _spriteRenderer.DOColor(_damage, _duration);
        _spriteRenderer.DOColor(_default, _duration).SetDelay(0.2f);
    }

    public void ChangeColorOnHealing()
    {
        _spriteRenderer.DOColor(_healing, _duration);
        _spriteRenderer.DOColor(_default, _duration).SetDelay(0.2f);
    }
}
