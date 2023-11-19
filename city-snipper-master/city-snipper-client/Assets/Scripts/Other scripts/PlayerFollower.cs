using UnityEngine;
using System.Collections;

public class PlayerFollower : MonoBehaviour 
{
    CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    public float maxForwardSpeed = 6;
    public float gravity = 20.0F;

    public AnimationClip Idle;
    public AnimationClip Walk;
    public Transform targetPlayer;
    public int followRange = 20;
    bool isNear = false;
	
	void Start () 
    {
        controller = GetComponent<CharacterController>();
        GetComponent<Animation>().clip = Idle;
        GetComponent<Animation>().wrapMode = WrapMode.Loop;
        GetComponent<Animation>().Play();
	}
	
	
	void FixedUpdate () 
    {
        float distance = Vector3.Distance(targetPlayer.transform.position, transform.position);
        Debug.Log("Distance: " + distance);
        if (distance <= followRange && !isNear && distance>3)
        {
            Vector3 lookPos = targetPlayer.transform.position - transform.position;
            lookPos.y = 0;
            Quaternion rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10);
            Debug.Log("InSide Outer IF");
            if (controller.isGrounded)
            {
                Debug.Log("Inside Inner IF");
                moveDirection = new Vector3(0, 0, 10f);
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= maxForwardSpeed;
            }
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
            GetComponent<Animation>().clip = Walk;
            GetComponent<Animation>().wrapMode = WrapMode.Once;
            GetComponent<Animation>().Play();

        }

        else if (distance<=5)
        {
            isNear = true;
            GetComponent<Animation>().clip = Idle;
            GetComponent<Animation>().wrapMode = WrapMode.Once;
            GetComponent<Animation>().Play();
        }

	}
}
