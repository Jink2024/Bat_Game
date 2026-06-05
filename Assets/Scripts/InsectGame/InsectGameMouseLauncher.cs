using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.WSA;
using UnityEngine;

public class InsectGameMouseLauncher : MonoBehaviour
{
   public InsectGameLauncher InsectGameLauncher;
   void Update()
   {
      if (Mouse.current.leftButton.wasPressedThisFrame)
      {
         Launch();
      }
   }

   private void Launch()
   {
      Vector2 aimDirection = GetAimDirection();
      
      InsectGameLauncher.Launch(aimDirection);
   }

   private Vector2 GetAimDirection()
   {
      Vector3 mouseWorld = GetMouseWorldPosition();
      return (mouseWorld - transform.position).normalized;
   }

   private Vector3 GetMouseWorldPosition()
   {
      Vector2 mouseScreen = Mouse.current.position.ReadValue();
      Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);
      mouseWorld.z = 0f;
      return mouseWorld;
   }
}

