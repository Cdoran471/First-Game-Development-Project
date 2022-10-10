using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Reference to the charcter controller that handles our collistions and movement
    public CharacterController controller;
    //Speed of the Player
    public float speed = 1f;

    void Update()
    {
        //Step 1 get current position
        //Vector3 currentPos = transform.position;
        Vector3 motion = Vector3.zero;

        //Step 2 get player input
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        //Step 3 set new position based on input and speed
        //The new value of the currentpos in x will be its current value, plus the speed
        //multiplied bu the input (-1 or 1) and the time.deltaTime.

        //currentPos.x = currentPos.x + speed * inputX * Time.deltaTime;

        //step 4

        //currentPos.z = currentPos.z + speed * inputY * Time.deltaTime;

        // This will get us the vector of our movement, instead of the game postion
        //motion.z = transform.forward.normalized.z * speed * inputY * Time.deltaTime;
        //motion.x = transform.forward.normalized.x * speed * inputX * Time.deltaTime;
        motion = (transform.forward * speed * inputY * Time.deltaTime)
            + (transform.right * speed * inputX * Time.deltaTime);
        //step 5 assign new position
        //transform.position = currentPos;
        controller.Move(motion);
    }
}
