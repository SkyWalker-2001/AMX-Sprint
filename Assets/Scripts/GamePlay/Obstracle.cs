using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstracle : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    public Vector2 move_Direction;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + move_Direction * Time.fixedDeltaTime);
    }
}
