using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
   public float speed = 2.0f;
   public GameObject cameraRef;
   private Rigidbody rb;

   private void Start()
   {
      rb = GetComponent<Rigidbody>();
      
   }

   private void Update()
   {
      CheckKeysPressed();
      CheckMouseMoved();
   }

   private void CheckKeysPressed()
   {
      if(Input.GetKeyDown(KeyCode.W))
      {
         rb.AddForce(Vector3.forward * speed);

      }

      



   }

   private void CheckMouseMoved()
   {
      if (Input.GetAxis("Mouse X") < 0) //Left
      {
         transform.Rotate(Vector3.down);
      }

      if (Input.GetAxis("Mouse X") > 0) //Right
      {
         transform.Rotate(Vector3.up);
      }

      if (Input.GetAxis("Mouse Y") < 0) //Down
      {
         if (cameraRef.transform.eulerAngles.x > 70 || cameraRef.transform.eulerAngles.x < 60)
         {
            cameraRef.transform.Rotate(Vector3.right);
         }

      }

      if (Input.GetAxis("Mouse Y") > 0) //Up
      {
         if (cameraRef.transform.eulerAngles.x > 300 || cameraRef.transform.eulerAngles.x < 290)
         {
            cameraRef.transform.Rotate(Vector3.left);
         }
      }
   }


}
