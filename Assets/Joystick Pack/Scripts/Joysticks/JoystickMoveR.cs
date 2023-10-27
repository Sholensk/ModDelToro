using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMoveR : MonoBehaviour
{
    FixedJoystickR joystickR;
    public Rigidbody2D rb;
    public float force;
    public Vector2 combinedValue;
    private float horizontalValue;
    private float verticalValue;
    public Vector2 initialValue=new Vector2(0,0);
    private Vector2 _direction;
    private float _force;
    private float _distance;
    public float slowdown = 0.95f;
    public float bounceforce = 100f;
    public bool FUCK;
    private CircleCollider2D _circleCollider;
    private void Start()
    {
        joystickR = FindAnyObjectByType<FixedJoystickR>();
        rb = GetComponent<Rigidbody2D>();
        _circleCollider = GetComponent<CircleCollider2D>();
    }
    private void FixedUpdate()
    {
        horizontalValue = joystickR.Horizontal;
        verticalValue = joystickR.Vertical;
        combinedValue = joystickR.Direction;
        /*_distance=Vector2.Distance(initialValue, combinedValue);
        _direction=(initialValue-combinedValue).normalized;
        _force = _distance * 10;*/

        if (combinedValue ==new Vector2(0,0))
        {
            if (FUCK)
            {
                FUCKINGHELL();
                //FUCK = true;
            }
            
            /*
            StopAllCoroutines();
            StartCoroutine(Push());
            */
        }
        else
        {
            _distance = Vector2.Distance(initialValue, combinedValue);
            _direction = (initialValue - combinedValue).normalized;
            _force = _distance * 1500;
            
        }

        rb.drag = slowdown;
        if (rb.velocity != new Vector2(0,0))
        {
            FUCK = false;
        }
        else if (rb.velocity.x <= 2f && !FUCK && rb.velocity.y <= 2f)
        {
            Debug.LogError("Se desactivo!!!!!!!!!!!!!");
            _circleCollider.isTrigger = true;
            this.enabled = false;
            FUCK = true;
        }

        /*
        if (rb.velocity != new Vector2(0, 0))
        {
            rb.velocity=(initialValue);
            _force = 0;
        }
        */
        /* if (combinedValue==initialValue)
         {
             rb.AddForce(combinedValue * 2);
             Debug.Log("equals values");
         }*/
    }

    public void FUCKINGHELL()
    {
        rb.AddForce(_direction * _force);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            Vector2 normal = collision.contacts[0].normal;
            rb.AddForce(-normal * bounceforce, ForceMode2D.Impulse);
        }
    }
}
