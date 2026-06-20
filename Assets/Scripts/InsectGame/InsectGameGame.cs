using DefaultNamespace;
using UnityEngine;

public class InsectGameGame : MonoBehaviour
{
    public InsectGameInsectSpawner InsectGameInsectSpawner;
    public InsectGameUI InsectGameUI;
    
    public static bool isPlaying = false;

    void Start()
    {
        InsectGameUI.ShowInsectStartScreen();
        InsectGameUI.HideInsectGameOverScreen();
        InsectGameUI.ResetScore();
        InsectGameUI.SetScoreText();
    }

    public void OnClickHideInsectStartScreen()
    {
        InsectGameUI.HideInsectStartScreen();
        InsectGameInsectSpawner.StartPlacing();
        isPlaying = true;
    }

    public void GameOver()
    {
        if (InsectGameScoreKeeper.GetScore() == 5)
        {
            InsectGameUI.ShowInsectGameOverScreen();

            InsectGameInsectSpawner.StopPlacing();
            InsectGameInsectSpawner.CleanupPlacerObjects();
            isPlaying = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        GameOver();
        
        InsectGameUI.SetScoreText();
        //print(score);
    }
}
