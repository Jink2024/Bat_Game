using UnityEngine;

public class MatchGame : MonoBehaviour
{
    public static int result = 0;
    public MatchGameUI MatchGameUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MatchGameUI.ShowMatchGameStartScreen();
        ResetMatchGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStartGame()
    {
        MatchGameUI.HideMatchGameStartScreen();
        MatchGameUI.ShowFirstQuestion();
    }

    public void OnClickFQCongratulation()
    {
        MatchGameUI.HideFirstQuestion();
        MatchGameUI.ShowWinFirstQuestion();

        result = result + 1;
    }

    public void OnClickLoseFirstQuestion()
    {
        MatchGameUI.HideFirstQuestion();
        MatchGameUI.ShowLoseFirstQuestion();

        result = result;
    }

    public void OnClickShowSecondQuestion()
    {
        MatchGameUI.HideWinFirstQuestion();
        MatchGameUI.HideLoseFirstQuestion();
        MatchGameUI.ShowSecondQuestion();
    }

    public void OnClickLoseSecondQuestion()
    {
        MatchGameUI.HideSecondQuestion();
        MatchGameUI.ShowSQLose();
    }

    public void OnClickWinSecondQuestion()
    {
        MatchGameUI.HideSecondQuestion();
        MatchGameUI.ShowSQWin();

        result = result + 1;
    }

    public void OnClickShowThirdQuestion()
    {
        MatchGameUI.HideSQLose();
        MatchGameUI.HideSQWin();
        MatchGameUI.ShowThirdQuestion();
    }

    public void OnClickWinTQ()
    {
        MatchGameUI.HideThirdQuestion();
        MatchGameUI.ShowTQWin();

        result = result + 1;
    }

    public void OnClickLoseTQ()
    {
        MatchGameUI.HideThirdQuestion();
        MatchGameUI.ShowTQLose();
    }

    public void OnClickShowMatchGameOver()
    {
        MatchGameUI.HideTQLose();
        MatchGameUI.HideTQWin();
        MatchGameUI.ShowMatchGameOver();
        MatchGameUI.SetResultText(result);
    }


    public void ResetMatchGame()
    {
        MatchGameUI.HideFirstQuestion();
        MatchGameUI.HideWinFirstQuestion();
        MatchGameUI.HideLoseFirstQuestion();
        
        MatchGameUI.HideSecondQuestion();
        MatchGameUI.HideSQLose();
        MatchGameUI.HideSQWin();
        
        MatchGameUI.HideTQLose();
        MatchGameUI.HideTQWin();
        MatchGameUI.HideThirdQuestion();
        
        MatchGameUI.HideMatchGameOver();

        result = 0;
    }
}
