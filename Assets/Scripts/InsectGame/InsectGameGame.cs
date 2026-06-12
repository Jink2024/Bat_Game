using UnityEngine;

public class InsectGameGame : MonoBehaviour
{
    public InsectGameInsectSpawner InsectGameInsectSpawner;
    public InsectGameUI InsectGameUI;
    public static bool isPlaying = false;
    int score;
    void Start()
    {
        //reset counter
        InsectGameUI.ShowInsectStartScreen();
        InsectGameUI.HideInsectGameOverScreen();
        InsectGameUI.ResetScore();
        InsectGameUI.SetScoreText(score);
    }

    public void OnClickHideInsectStartScreen()
    {
        InsectGameUI.HideInsectStartScreen();
        InsectGameInsectSpawner.StartPlacing();
        isPlaying = true;
    }

    public void GameOver()
    {
        if (score == 5)
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
        //GameOver();
    }
}
