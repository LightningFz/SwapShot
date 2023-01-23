//made by Fawaz

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    this class controls the player movement
    it controls the jump power, speed, max amount of jumps
    as well as making sure there arent any bugs with the player
 */
public class playerMovement : MonoBehaviour
{


    //variables
    public float runSpeed = 40;
    public float jumpPower = 5;
    public float checkRadius;
    public int maxJumps = 1;
    public bool isFacingLeft = true;
    public bool _isJumping = false;
    public AudioClip jumpSound;
    public bool isGrounded;
    private float horizontal;
    private int jumpCount;
    public bool soundFix;


    //[SerializeField] means that it appears in the inspector 
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundObject;

    Rigidbody2D rb;

    //called before the game starts
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //called on the first frame
    private void Start()
    {
        jumpCount = maxJumps;
    }

    //called every frame
    void Update()
    {
        faceRight();
        getInput();
    }

    //called at a fixed rate
    private void FixedUpdate()
    {
        Grounded();
        move();
    }

    //check if the player is touching the ground or not
    public void Grounded()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundObject);
        if (isGrounded)
        {
            jumpCount = maxJumps;
        }
    }

    //check whether the player is facing the right direction or not   
    public void faceRight()
    {
        if (horizontal < 0 && isFacingLeft)
        {
            flip();
        }
        else if (horizontal > 0 && !isFacingLeft)
        {
            flip();
        }
    }
    //get the player inputs 
    public void getInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            _isJumping = true;
            soundFix = true;
        }
        if(_isJumping == true && isGrounded == true && soundFix == true)
        {
            AudioSource.PlayClipAtPoint(jumpSound,transform.position);
            soundFix = false;
        }

    }
    //apply forces to mave the player move 
    private void move()
    {
        rb.velocity = new Vector2(horizontal * runSpeed, rb.velocity.y);
        if (_isJumping && jumpCount > 0)
        {
            rb.AddForce(new Vector2(0f, jumpPower));
            jumpCount--;
        }
        _isJumping = false;
        soundFix = false;
    }

    //flip the player on the y axis
    public void flip()
    {
        isFacingLeft = !isFacingLeft;
        transform.Rotate(0f, 180, 0f);
    }
}
