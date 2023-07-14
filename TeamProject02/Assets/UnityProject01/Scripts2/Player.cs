using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioClip deathClip;
    public float jumpForce = 700f;

    private int jumpCount = 0;
    private bool isGrounded = false;
    public bool isDead = false;

    private Rigidbody2D playerRigid = default;
    private Animator animator = default;
    private AudioSource playerAudio = default;
    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead) { return; }

        if (Input.GetButtonDown("Jump") && jumpCount < 1)
        {

            jumpCount += 1;
            playerRigid.velocity = Vector2.zero;
            playerRigid.AddForce(new Vector2(0, jumpForce));
            //playerAudio.Play();
            playerRigid.velocity = playerRigid.velocity * 0.5f;
        }
        //float horizon = Input.GetAxis("Horizontal");
        //float movement = horizon * 10 * Time.deltaTime;
        //transform.Translate(Vector3.right * movement);

        animator.SetBool("Groun", isGrounded);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (0.7f < collision.contacts[0].normal.y)
        {
            isGrounded = true;
            jumpCount = 0;
        }
        
    }
   
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;

    }

    public void Die()
    {
        animator.SetTrigger("Die");
        //playerAudio.clip = deathClip;
        //playerAudio.Play();

        playerRigid.velocity = Vector2.zero;
        isDead = true;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Dead") && isDead == false)
        {
            Die();
        }
    }

}
