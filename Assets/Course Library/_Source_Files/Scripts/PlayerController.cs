using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int jumpPower = 1400;
    public int gravModifier = 5;
    public bool isOnGround = true;
    private Rigidbody rb = null;
    public bool GameOver = false;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public ParticleSystem dirtParticle1;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        //set gravity and define rb
        rb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravModifier;
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //jump and mark player as not on ground
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !GameOver)
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            dirtParticle1.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {       //check what colliding with, if ground, reset jump, if obstacle, game over
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            if (!GameOver)
            {
                dirtParticle.Play();
                dirtParticle1.Play();
            }
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            dirtParticle1.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
