using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float runSpeed = 40;
    public float jumpPower = 5;
    public float checkRadius;
    public int maxJumps = 1;


    public bool isFacingLeft = true;
    public bool _isJumping = false;
    public AudioSource jumpSound;
    public bool isGrounded;
    private float horizontal;
    private int jumpCount;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundObject;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        jumpCount = maxJumps;
        jumpSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        faceRight();
        getInput();
    }

    private void FixedUpdate()
    {
        Grounded();
        move();
    }

    public void Grounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundObject);
        if (isGrounded)
        {
            jumpCount = maxJumps;
        }
    }

    public void faceRight()
    {
        if (horizontal < 0 && isFacingLeft)
        {
            Flip();
        }
        else if (horizontal > 0 && !isFacingLeft)
        {
            Flip();
        }
    }
    public void getInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            _isJumping = true;
        }
        if(_isJumping == true && isGrounded == true)
        {
            jumpSound.Play();
        }

    }
    private void move()
    {
        rb.velocity = new Vector2(horizontal * runSpeed, rb.velocity.y);
        if (_isJumping && jumpCount > 0)
        {
            rb.AddForce(new Vector2(0f, jumpPower));
            jumpCount--;
        }
        _isJumping = false;
    }

    public void Flip()
    {
        isFacingLeft = !isFacingLeft;
        transform.Rotate(0f, 180, 0f);
    }
}
