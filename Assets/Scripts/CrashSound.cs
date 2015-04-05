using UnityEngine;
using System.Collections;

public class CrashSound : MonoBehaviour {

    public AudioClip crash1;

    private AudioSource audioSource;

	// Use this for initialization
	void Awake () {

        audioSource = GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
    }

    void OnCollisionEnter(Collision col)
    {
        audioSource.PlayOneShot(crash1, 0.7F);
    }
}
