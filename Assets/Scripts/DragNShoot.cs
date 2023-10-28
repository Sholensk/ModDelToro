using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNShoot : MonoBehaviour
{
    private Vector2 _startPos;
    private Vector2 _endPos;
    private Vector2 _direction;
    private float _force;
    private float _distance;

    [SerializeField] private Rigidbody2D _rigidbody;
    public SoundEffects soundEffects;  // Referencia al script de efectos de sonido

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                _startPos = Camera.main.ScreenToWorldPoint(touch.position);
            }

            if (touch.phase == TouchPhase.Ended)
            {
                _endPos = Camera.main.ScreenToWorldPoint(touch.position);
                _distance = Vector2.Distance(_startPos, _endPos);
                _direction = (_startPos - _endPos).normalized;
                _force = _distance * 100;
                _rigidbody.AddForce(_direction * _force);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Asumiendo que todas las casillas tienen una etiqueta "Casilla"
        if (collision.gameObject.CompareTag("Tablero1"))
        {
            soundEffects.PlaySlotSound();
        }
    }
}


