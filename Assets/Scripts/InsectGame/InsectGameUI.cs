using TMPro;
using UnityEngine;

public class InsectGameUI : MonoBehaviour
{
    
    public CanvasGroup InsectGameOverScreenCanvasGroup;
    public CanvasGroup InsectStartScreenCanvasGroup;
    public InsectGameInsect InsectGameInsect;

    public TMP_Text scoreText;
    public static int score;
    
    public void SetScoreText()
    {
        scoreText.text = "Score: " + score;
        print(score);
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
