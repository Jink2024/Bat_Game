using TMPro;
using UnityEngine;

public class MatchGameUI : MonoBehaviour
{
    
    public CanvasGroup MatchGameStartScreenCanvasGroup;
    public CanvasGroup FirstQuestionCanvasGroup;
    public CanvasGroup LoseFirstQuestionCanvasGroup;
    public CanvasGroup WinFirstQuestionCanvasGroup;
    
    public CanvasGroup SecondQuestionCanvasGroup;
    public CanvasGroup WinSQCanvasGroup;
    public CanvasGroup LoseSQCanvasGroup;
    
    public CanvasGroup ThirdQuestionCanvasGroup;
    public CanvasGroup TQWinCanvasGroup;
    public CanvasGroup TQLoseCanvasGroup;
    
    public CanvasGroup MatchGameOverCanvasGroup;
    
    public TMP_Text MatchResultText;
    public static int result;

    public void SetResultText(int result)
    {
        MatchResultText.text = result + " / 3";
    }

    public void ResetResult()
    {
        MatchResultText.text = "Score: 0";
    }
    public void ShowMatchGameOver()
    {
        CanvasGroupDisplayer.Show(MatchGameOverCanvasGroup);
    }

    public void HideMatchGameOver()
    {
        CanvasGroupDisplayer.Hide(MatchGameOverCanvasGroup);
    }

    public void HideThirdQuestion()
    {
        CanvasGroupDisplayer.Hide(ThirdQuestionCanvasGroup);
    }

    public void ShowThirdQuestion()
    {
        CanvasGroupDisplayer.Show(ThirdQuestionCanvasGroup);
    }
    
    public void ShowTQLose()
    {
        CanvasGroupDisplayer.Show(TQLoseCanvasGroup);
    }

    public void HideTQLose()
    {
        CanvasGroupDisplayer.Hide(TQLoseCanvasGroup);
    }
    
    public void ShowTQWin()
    {
        CanvasGroupDisplayer.Show(TQWinCanvasGroup);
    }

    public void HideTQWin()
    {
        CanvasGroupDisplayer.Hide(TQWinCanvasGroup);
    }
    
    public void ShowSQWin()
    {
        CanvasGroupDisplayer.Show(WinSQCanvasGroup);
    }

    public void HideSQWin()
    {
        CanvasGroupDisplayer.Hide(WinSQCanvasGroup);
    }
    
    public void ShowSQLose()
    {
        CanvasGroupDisplayer.Show(LoseSQCanvasGroup);
    }

    public void HideSQLose()
    {
        CanvasGroupDisplayer.Hide(LoseSQCanvasGroup);
    }
    public void ShowSecondQuestion()
    {
        CanvasGroupDisplayer.Show(SecondQuestionCanvasGroup);
    }

    public void HideSecondQuestion()
    {
        CanvasGroupDisplayer.Hide(SecondQuestionCanvasGroup);
    }
    
    public void HideWinFirstQuestion()
    {
        CanvasGroupDisplayer.Hide(WinFirstQuestionCanvasGroup);
    }

    public void ShowWinFirstQuestion()
    {
        CanvasGroupDisplayer.Show(WinFirstQuestionCanvasGroup);
    }
    
    public void HideLoseFirstQuestion()
    {
        CanvasGroupDisplayer.Hide(LoseFirstQuestionCanvasGroup);
    }

    public void ShowLoseFirstQuestion()
    {
        CanvasGroupDisplayer.Show(LoseFirstQuestionCanvasGroup);
    }
    
    public void HideMatchGameStartScreen()
    {
        CanvasGroupDisplayer.Hide(MatchGameStartScreenCanvasGroup);
    }

    public void ShowMatchGameStartScreen()
    {
        CanvasGroupDisplayer.Show(MatchGameStartScreenCanvasGroup);
    }
    
    public void HideFirstQuestion()
    {
        CanvasGroupDisplayer.Hide(FirstQuestionCanvasGroup);
    }

    public void ShowFirstQuestion()
    {
        CanvasGroupDisplayer.Show(FirstQuestionCanvasGroup);
    }
}
