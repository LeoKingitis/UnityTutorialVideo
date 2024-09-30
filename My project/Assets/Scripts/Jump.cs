using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
   [SerializeField] private Rigidbody2D rb;
   [SerializeField] private float jumpHeigt;
   [SerializeField] private LayerMask groundLayer;
   [SerializeField] private Transform groundChecker;


   private bool IsGrounded()
   {
      return Physics2D.OverlapCircle(groundChecker.position, 0.1f, groundLayer);
   }

   public void OnJump()
   {
      if (IsGrounded())
      {
         rb.velocity = new Vector2(rb.velocity.x, jumpHeigt);
      }
   }
}
