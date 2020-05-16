﻿using System.Collections;
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
         cameraRef.transform.Rotate(Vector3.right);
         
      }

      if (Input.GetAxis("Mouse Y") > 0) //Up
      {
         cameraRef.transform.Rotate(Vector3.left);
         if (cameraRef.transform.eulerAngles.x < -60)
         {
            Debug.Log("FUCK");
            cameraRef.transform.rotation = new Quaternion(-60, cameraRef.transform.rotation.y, cameraRef.transform.rotation.z, cameraRef.transform.rotation.w);
         }
      }
   }


}
