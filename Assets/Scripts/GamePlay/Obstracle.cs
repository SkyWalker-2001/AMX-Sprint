using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstracle : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    public float move_Vector_X;
    public Vector2 move_Direction;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

        move_Direction = new Vector2(move_Vector_X,0);
    }

    private void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + move_Direction * Time.deltaTime);
    }
}
