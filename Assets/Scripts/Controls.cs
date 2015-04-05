using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	//[SerializeField] private float m_JumpForce = 400f;                  // Amount of force added when the player jumps.

    private Rigidbody2D m_Rigidbody2D;
	public float maxSpeed = 5f;
	public float maxTorque = 2f;
    
    public AudioClip crash1;

    private AudioSource audioSource;

	private void Awake()
	{
		// Setting up references.
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(crash1, 1F);
    }

	
	// Update is called once per frame
	void FixedUpdate () {
		float thrust = Input.GetAxisRaw ("Vertical");
        //if (thrust != 0)
            audioSource.PlayOneShot(crash1,1F);
		//m_Rigidbody2D.velocity = new Vector2 (m_Rigidbody2D.velocity.x, move * maxSpeed);
		m_Rigidbody2D.AddRelativeForce(new Vector2 (0f, thrust * maxSpeed));
		//m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
		float turn = -Input.GetAxisRaw ("Horizontal");
		m_Rigidbody2D.AddTorque(turn * maxTorque);
	}
}
