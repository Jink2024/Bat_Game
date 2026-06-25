using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class DGGame : MonoBehaviour
{
    private bool isGameRunning = false;
    public DGUI DGUI;
    
    void Start()
    {
        //isGameRunning = false;
        DGUI.ShowDGStartScreenCanvas();
        DGUI.HideDGGameOverCanvas();
    }
    
    public bool IsGameRunning()
    {
        print(isGameRunning + " so says Game");
        return isGameRunning;
    }

    public void OnStartButtonClicked()
    {
        StartGame();
    }

    public void StartGame()
    {
        DGUI.HideDGStartScreenCanvas();
        isGameRunning = true;
    }

    public void GameOver()
    {
        DGUI.ShowDGGameOverCanvas();
        //isGameRunning = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
