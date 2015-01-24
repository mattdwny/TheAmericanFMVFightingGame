using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour
{
	public float health = 100;
	public float current_x;
	public float current_y;
	public int facing = 1;
	public float moveSpeed = 6f;
	public float jumpSpeed = 20f;
	private bool grounded = false;
	private const int MAX_JUMPS = 2;
	public int hitstun_count;

	private int jumpsRemaining;
	public float velX;
	public float velY;
	private float grav = 40f;
	private int gravCounter;
	private int jumpCounter;
	private const float MAX_JUMP_HEIGHT = 60;
	private bool jumping;
	// Use this for initialization
	void Start () 
	{
		jumpsRemaining = MAX_JUMPS;
		grounded = false;
		transform.rigidbody2D.isKinematic = true;
		velX = .5f;
		velY = .3f;
		gravCounter = 0;
		jumpCounter = 0;
		jumping = false;
		current_x = transform.position.x;
		current_y = transform.position.y;
		hitstun_count = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		grounded = isTouchingGround();
		
		if (!grounded) velY -= grav/2 * Time.deltaTime;
		Move();
		if (!grounded) velY -= grav/2 * Time.deltaTime;
		
		
		
		//...............................................................................
		//test input
		
		if (Input.GetButtonDown("Jump"))
			Jump();
		if (Input.GetKey(KeyCode.A))
			moveLeft();
		if (Input.GetKey(KeyCode.D))
			moveRight();
		
		if (jumping)
			Move();
		Move();
		
		
		//test input
		//...............................................................................
		
	}
	
	void Move()
	{
		transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, velY, 0f) * Time.deltaTime;
	}
	
	void moveLeft()
	{
		transform.position = new Vector2(transform.position.x - velX, transform.position.y);
		
	}
	void moveRight()
	{
		transform.position = new Vector2(transform.position.x + velX, transform.position.y);
	}
	void moveUp()
	{
		transform.position = new Vector2(transform.position.x, transform.position.y + velY);
	}
	void moveDown()
	{
		if(!isTouchingGround())
			transform.position = new Vector2(transform.position.x, transform.position.y - velY);
	}
	void Jump()
	{
		if (jumpsRemaining > 0)
		{
			if (grounded) grounded = false;
			
			jumping = true;
			
			
			Debug.Log("in jump");
			
			jumpsRemaining--;
			
			//moveUp();
			
			velY = jumpSpeed;
			
			//grav *= -1;
		}
	}
	
	bool isTouchingGround()
	{
		if (transform.position.y <= 0 && velY < 0f)
		{
			velY = 0;
			transform.position = new Vector3(transform.position.x, 0f, 0f);
			jumpsRemaining = MAX_JUMPS;
			return true;
		}
		return false;
	}
}
