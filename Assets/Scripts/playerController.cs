using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public GameObject player;
    public float moveSpeed = 5f;
    public float jumpSpeed = 8.0F; //°_¸õ¶ZÂ÷
    public float gravity = -9.8F;  //­«¤O
    public CharacterController charController;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if(isGrounded && velocity.y<0)
        {
            velocity.y = -2f;
        }

        Vector3 move = transform.right * x + transform.forward * z;
        charController.Move(move * jumpSpeed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpSpeed * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        charController.Move(velocity * Time.deltaTime);
        
        if(velocity.y == 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                normalState();
            }
            
        }
        
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("coll exist");
        if (collision.gameObject.transform.tag == "climbable")
        {
            //Debug.Log("press f1");
            if (Input.GetKey(KeyCode.F))
            {
                Debug.Log("face up");
                gravity = 0f;
                velocity.y = 0f;
                var rotationVector = transform.rotation.eulerAngles;
                rotationVector.x = -90;
                this.gameObject.transform.rotation = Quaternion.Euler(rotationVector);
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        normalState();
    }

    private void normalState()
    {
        gravity = -9.8f;
        velocity.y = -2f;
        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.x = 0;
        this.gameObject.transform.rotation = Quaternion.Euler(rotationVector);
    }
    
}
