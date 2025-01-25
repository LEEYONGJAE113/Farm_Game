using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    private Vector2 _inputVec;
    private Rigidbody2D _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 nextVec = _inputVec * 3/*movespeed*/ * Time.fixedDeltaTime;
        Vector2 nextPos = _rb.position + nextVec;

        _rb.MovePosition(nextPos);
        _rb.linearVelocity = Vector2.zero;
    }


    void OnMove(InputValue iValue)
    {
        _inputVec = iValue.Get<Vector2>();
    }
}
