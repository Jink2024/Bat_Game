using DefaultNamespace;
using TMPro;
using UnityEngine;

public class InsectGameUI : MonoBehaviour
{
    
    public CanvasGroup InsectGameOverScreenCanvasGroup;
    public CanvasGroup InsectStartScreenCanvasGroup;
    public InsectGameInsect InsectGameInsect;

    public TMP_Text scoreText;

    public void Update()
    {
        SetScoreText();
    }
    
    public void SetScoreText()
    {
        scoreText.text = "Score: " + InsectGameScoreKeeper.GetScore();
    }

    public void ResetScore()
    {
        InsectGameScoreKeeper.ResetScore();
        SetScoreText();
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
