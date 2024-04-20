using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float _speed = 1f;
    public float _width = 6f;

    public SpriteRenderer _spriteRenderer;

    public Vector2 _startSize;

    // Start is called before the first frame update
    public void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startSize = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);
    }

    // Update is called once per frame
    public void Update()
    {
        _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + _speed * Time.deltaTime, _spriteRenderer.size.y);
        if (_spriteRenderer.size.x > _width){
            _spriteRenderer.size = _startSize;
        }
    }
}
