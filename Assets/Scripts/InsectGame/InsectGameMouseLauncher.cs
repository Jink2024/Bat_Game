using UnityEngine;
using UnityEngine.InputSystem;

public class InsectGameMouseLauncher : MonoBehaviour
{
   public InsectGameLauncher InsectGameLauncher;
   public InsectGameGame InsectGameGame;
   void Update()
   {
      if (Mouse.current.leftButton.wasPressedThisFrame && InsectGameGame.isPlaying)
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

