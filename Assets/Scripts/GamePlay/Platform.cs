using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _boxCollider2D;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(_boxCollider2D.bounds.center, _boxCollider2D.bounds.size);
    }
}
