using TMPro;
using UnityEngine;

public class InsectGameUI : MonoBehaviour
{
    public TMP_Text scoreText;
    
    public CanvasGroup InsectGameOverScreenCanvasGroup;
    public CanvasGroup InsectStartScreenCanvasGroup;

    public static int score;
    
    public void SetScoreText(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void ResetScore()
    {
        scoreText.text = "Score: 0";
    }
    
    public void HideInsectGameOverScreen()
    {
        CanvasGroupDisplayer.Hide(InsectGameOverScreenCanvasGroup);
    }

    public void ShowInsectGameOverScreen()
    {
        CanvasGroupDisplayer.Show(InsectGameOverScreenCanvasGroup);
    }
    
    public void HideInsectStartScreen()
    {
        CanvasGroupDisplayer.Hide(InsectStartScreenCanvasGroup);
    }

    public void ShowInsectStartScreen()
    {
        CanvasGroupDisplayer.Show(InsectStartScreenCanvasGroup);
    }
}
