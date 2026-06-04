using UnityEngine;

public class TeachingScene : MonoBehaviour
{
    public CanvasGroup DietCanvas;
    public UI UI;
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // hide the diet canvas screen at the start of the game
        UI.HideDiet();
        UI.HideHabitat();
    }

    public void OnClickShowDiet()
    {
        UI.ShowDiet();
        UI.HideTeachingButtons();
        
        // some Diet achievement here
        // but only the first time?
    }

    public void OnClickHideDiet()
    {
        UI.HideDiet();
        UI.ShowTeachingButtons();
    }
    
    public void OnClickShowHabitat()
    {
        UI.ShowHabitat();
        UI.HideTeachingButtons();
        
        // some Diet achievement here
        // but only the first time?
    }

    public void OnClickHideHabitat()
    {
        UI.HideHabitat();
        UI.ShowTeachingButtons();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
