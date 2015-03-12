using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	//[SerializeField] private float m_JumpForce = 400f;                  // Amount of force added when the player jumps.

	private Rigidbody2D m_Rigidbody2D;
	public float maxSpeed = 10f;
	public float maxTorque = 5f;

	private void Awake()
	{
		// Setting up references.
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//float move = Input.GetAxisRaw ("Vertical");
		Vector2 axis = new Vector2 (-Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		//m_Rigidbody2D.velocity = new Vector2 (m_Rigidbody2D.velocity.x, move * maxSpeed);
		m_Rigidbody2D.AddRelativeForce(new Vector2 (0f, axis.y * maxSpeed));
		//m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
		//float turn = -Input.GetAxis ("Horizontal");
		m_Rigidbody2D.AddTorque(axis.x * maxTorque);
	}
}
