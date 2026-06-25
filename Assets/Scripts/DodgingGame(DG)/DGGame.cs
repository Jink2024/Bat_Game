using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class DGGame : MonoBehaviour
{
    public bool isGameRunning = true;
    public DGUI DGUI;
    
    void Start()
    {
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
