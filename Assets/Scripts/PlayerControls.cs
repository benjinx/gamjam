using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
   public float speed = 2.0f;
   private Rigidbody rb;

   private void Start()
   {
      rb = GetComponent<Rigidbody>();
   }

   private void Update()
   {
      CheckKeysPressed();
   }

   private void CheckKeysPressed()
   {
      if(Input.GetKeyDown(KeyCode.W))
      {
         rb.AddForce(Vector3.forward * speed);

      }

   }


}
