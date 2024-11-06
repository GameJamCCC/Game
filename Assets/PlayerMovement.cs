using System.Collections;         //                        //
using System.Collections.Generic; // Bunch of preprocessors //
using UnityEngine;                //                        //

public class PlayerMovement : MonoBehaviour{

        public CharacterController controller; //keep this, its to specify its for a character controller
        public float gravity = -9.81f;

        public float speed = 10f;
        Vector3 velocity;

        void Update(){
                float x = Input.GetAxis("Horizontal");
                float z = Input.GetAxis("Vertical");

                Vector3 move = transform.right * x + transform.forward * z;

                controller.Move(move * speed * Time.deltaTime);
                velocity.y += gravity * Time.deltaTime;

                controller.Move(velocity * Time.deltaTime);
        }
}
