using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody simpRb;
    public float jumpforce;
    public float gravityModifier;
    private float speed = 20;
    private float turnSpeed = 60;
    private float horizontalInput;
    private float forwardInput;
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        simpRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        //playerAnim = GetComponent<Animator>();

    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
           // playerAudio.PlayOneShot(jumpSound, 1.0f);
            //dirtParticle.Stop();
            simpRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            //isOnGround = false;
            //playerAnim.SetTrigger("Jump_trig");
        }
        // This is whre we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move the Vehicle Foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //We turn the vehicle
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
