using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElementType;

namespace Player {
    public class PlayerController : MonoBehaviour
    {
        //移動
        private float _horizontal;
        private float _speed = 8f;
        private float _jumpingPower = 15;
        private bool _isFacingRight = true;

        //ダッシュ
        private bool _canDash = true;
        private bool _isDashing;
        private float _dashingPower = 24;
        private float _dashingTime = 0.2f;
        private float _dashingCooldown = 1.0f;


        //ジャンプ  
        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private Transform _groundCheck;
        [SerializeField] private LayerMask _groundLayer;


        [SerializeField] private TrailRenderer _tr;

        //降りる
        private GameObject _currntOneWayPlatform;

        [SerializeField] private CapsuleCollider2D _playerCollider;

        //アニメーション
        [SerializeField] private Animator animator;
        [SerializeField] private PlayerStatus Status;

        private bool isRuning = false;
        private bool isJumping = false;
        private bool isFalling = false;




        // Start is called before the first frame update
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {

            if (_isDashing)
            {
                return;
            }

            _horizontal = Input.GetAxisRaw("Horizontal");


            if (isFalling) isRuning = false;
            else isRuning = _horizontal != 0;
            isFalling = _rb.velocity.y < -0.5f;
            if (IsGrounded())
            {
                isJumping = false;
            }


            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
            {
                if (Input.GetKey(KeyCode.DownArrow) && _currntOneWayPlatform != null)
                {
                    StartCoroutine(DisableCollision());
                }
                else
                {
                    Jump();
                }
            }

            if (Input.GetKeyDown(KeyCode.Space) && _rb.velocity.y > 0f)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, _rb.velocity.y * 1.1f);
            }

            if (Input.GetKeyDown(KeyCode.LeftShift) && _canDash)
            {
                StartCoroutine(Dash());
            }

            if (Input.GetKey(KeyCode.Tab))
            {

            }

            if (Input.GetKey(KeyCode.Q))
            {

            }

            if (Input.GetKey(KeyCode.W))
            {

            }

            if (Input.GetKey(KeyCode.E))
            {

            }

            if (Input.GetKey(KeyCode.A))
            {

            }

            if (Input.GetKey(KeyCode.S))
            {

            }

            if (Input.GetKey(KeyCode.D))
            {

            }

            if (Input.GetKey(KeyCode.Z))
            {

            }

            if (Input.GetKey(KeyCode.X))
            {

            }

            if (Input.GetKey(KeyCode.C))
            {

            }

            Flip();
            AnimationState();
        }

        private void FixedUpdate()
        {
            if (_isDashing)
            {
                return;
            }
            _rb.velocity = new Vector2(_horizontal * _speed, _rb.velocity.y);
        }

        private bool IsGrounded()
        {
            return Physics2D.OverlapCircle(_groundCheck.position, 0.2f, _groundLayer);
        }

        private void Jump()
        {
            isJumping = true;
            _rb.velocity = new Vector2(_rb.velocity.x, _jumpingPower);
        }

        private void Flip()
        {
            if(_isFacingRight && _horizontal < 0f || !_isFacingRight && _horizontal > 0f)
            {
                _isFacingRight = !_isFacingRight;
                Vector3 localScale = transform.localScale;
                localScale.x *= -1f;
                transform.localScale = localScale;
            }
        }

        private void AnimationState()
        {
            animator.SetBool("isRuning", isRuning);
            animator.SetBool("isJumping", isJumping);
            animator.SetBool("isFalling", isFalling);
            if (Status.STATE == AbnormalStatus.NORMAL)
            {
                animator.SetFloat("_abnormal", 0);
            }
            else if (Status.STATE == AbnormalStatus.NASTY)
            {
                animator.SetFloat("_abnormal", 0.5f);
            }
            else if (Status.STATE == AbnormalStatus.FAINT)
            {
                animator.SetFloat("_abnormal", 1f);
            }
        }

        private IEnumerator Dash()
        {
            _canDash = false;
            _isDashing = true;
            float originalGravity = _rb.gravityScale;
            _rb.gravityScale = 0f;
            _rb.velocity = new Vector2(transform.localScale.x * _dashingPower, 0f);
            //_tr.emitting = true;
            yield return new WaitForSeconds(_dashingTime);
            //_tr.emitting = false;
            _rb.gravityScale = originalGravity;
            _isDashing = false;
            yield return new WaitForSeconds(_dashingCooldown);
            _canDash = true;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("OneWayPlatform"))
            {
                _currntOneWayPlatform = collision.gameObject;
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("OneWayPlatform"))
            {
                _currntOneWayPlatform = null;
            }
        }

        private IEnumerator DisableCollision()
        {
            BoxCollider2D platformCollider = _currntOneWayPlatform.GetComponent<BoxCollider2D>();

            Physics2D.IgnoreCollision(_playerCollider, platformCollider);
            yield return new WaitForSeconds(0.5f);
            Physics2D.IgnoreCollision(_playerCollider, platformCollider, false);
        }
    }
}
