using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.SceneManagement;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class Player : MonoBehaviour
{
    [SerializeField] float _groundCheckDistance;
    [SerializeField] public LayerMask what_is_ground;

    public float JumpForce;
    private Vector2 _JumpVector;
    private Rigidbody2D _rigidbody2D;

    private bool _isGrounded;

    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }

    private void OnDisable()
    {
        EnhancedTouchSupport.Disable();
    }

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

        _JumpVector = new Vector2(0, JumpForce);
    }

    private void Update()
    {
        Input_System();
    }

    private void Input_System()
    {
        if (Touch.fingers[0].isActive)
        {

            Touch myTouch = Touch.activeTouches[0];
            Vector3 touchPos = myTouch.screenPosition;


#if UNITY_EDITOR

            if (touchPos.x == Mathf.Infinity)
            {
                return;
            }

#endif


            if (Touch.activeTouches[0].phase == TouchPhase.Began)
            {
                Jump_Controller();

            }
            // if (Touch.activeTouches[0].phase == TouchPhase.Moved)
            // {
            // }
            // if (Touch.activeTouches[0].phase == TouchPhase.Stationary)
            // {
            // }

        }
    }

    private void Jump_Controller()
    {
        _isGrounded = Physics2D.Raycast(transform.position, Vector2.down, _groundCheckDistance, what_is_ground);

        if (_isGrounded)
            _rigidbody2D.AddForce(_JumpVector, ForceMode2D.Impulse);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y - _groundCheckDistance, transform.position.y));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Obstracle>() != null)
        {
            Destroy(other.gameObject);
            StartCoroutine(LoadMainMenue());
        }
    }

    public IEnumerator LoadMainMenue(){
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MainMenue");
    } 
}
