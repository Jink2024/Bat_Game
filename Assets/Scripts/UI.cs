using UnityEngine;

public class UI : MonoBehaviour
{
    //public TMP_Text scoreText;
    //public TMP_Text TimeText;
    //public GameTimer GameTimer;
    public CanvasGroup TeachingButtonsCanvasGroup;
    public CanvasGroup DietCanvasGroup;
    
    
   /* public void SetScoreText(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void ResetScore()
    {
        scoreText.text = "Score: 0";
    }
    */
   public void HideTeachingButtons()
   {
       CanvasGroupDisplayer.Hide(TeachingButtonsCanvasGroup);
   }

   public void ShowTeachingButtons()
   {
       CanvasGroupDisplayer.Show(TeachingButtonsCanvasGroup);
   }
   
   public void HideDiet()
   {
       CanvasGroupDisplayer.Hide(DietCanvasGroup);
   }

   public void ShowDiet()
   {
       CanvasGroupDisplayer.Show(DietCanvasGroup);
   }
   
    
}
