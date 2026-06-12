using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    
    //public TMP_Text TimeText;
    //public GameTimer GameTimer;
    public CanvasGroup TeachingButtonsCanvasGroup;
    public CanvasGroup DietCanvasGroup;
    public CanvasGroup HabitatCanvasGroup;
    public CanvasGroup FactsCanvasGroup;
    public CanvasGroup TeachingOverButtonsCanvasGroup;
   
   
   public void HideTeachingButtons()
   {
       CanvasGroupDisplayer.Hide(TeachingButtonsCanvasGroup);
   }

   public void ShowTeachingButtons()
   {
       CanvasGroupDisplayer.Show(TeachingButtonsCanvasGroup);
   }
   
   public void HideTeachingOverButtons()
   {
       CanvasGroupDisplayer.Hide(TeachingOverButtonsCanvasGroup);
   }

   public void ShowTeachingOverButtons()
   {
       CanvasGroupDisplayer.Show(TeachingOverButtonsCanvasGroup);
   }
   
   public void HideDiet()
   {
       CanvasGroupDisplayer.Hide(DietCanvasGroup);
   }

   public void ShowDiet()
   {
       CanvasGroupDisplayer.Show(DietCanvasGroup);
   }
   
   public void HideHabitat()
   {
       CanvasGroupDisplayer.Hide(HabitatCanvasGroup);
   }

   public void ShowHabitat()
   {
       CanvasGroupDisplayer.Show(HabitatCanvasGroup);
   }
    
   public void HideFacts()
   {
       CanvasGroupDisplayer.Hide(FactsCanvasGroup);
   }

   public void ShowFacts()
   {
       CanvasGroupDisplayer.Show(FactsCanvasGroup);
   }
}
