using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed = 5f;//���ʳt��
    public float jumpSpeed = 8.0F; //�_���Z��
    public float gravity = 20.0F;  //���O
    public float moveSpeedDefault = 10.0F;  //���O
    public float moveSpeedUP = 20.0F;  //���O
    private Vector3 moveDirection = Vector3.zero;
    CharacterController charController;


    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>(); //��CharacterController�j��controller
    }

    // Update is called once per frame
    void Update()
    {
        //move();
        if (charController.isGrounded) //�p�G�b�a�O�A�~�i����
        {
            //��oHorizontal�b �b-1��1�����B�� A D ���k�AW S �e ��
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= moveSpeed;
            if (Input.GetButton("Jump"))
            { moveDirection.y = jumpSpeed; }

        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeedUP;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeedDefault;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        charController.Move(moveDirection * Time.deltaTime);

        
    }


}
