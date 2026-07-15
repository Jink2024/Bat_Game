
using UnityEngine;

public class DGGame : MonoBehaviour
{
    public bool isGameRunning = false;
    public DGUI DGUI;
    
    void Start()
    {
        //isGameRunning = false;
        DGUI.HideDGGameWonCanvas();
        DGUI.ShowDGStartScreenCanvas();
        DGUI.HideDGGameOverCanvas();
    }
    
    public bool IsGameRunning()
    {
        isGameRunning = isGameRunning;
        return isGameRunning;
    }

    public void OnStartButtonClicked()
    {
        StartGame();
        isGameRunning = true;
    }

    public void StartGame()
    {
        DGUI.HideDGStartScreenCanvas();
        isGameRunning = true;
    }

    public void GameOver()
    {
        DGUI.ShowDGGameOverCanvas();
        isGameRunning = false;
    }

    public void GameWon()
    {
        DGUI.ShowDGGameWonCanvas();
        isGameRunning = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
