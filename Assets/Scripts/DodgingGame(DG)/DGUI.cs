using UnityEngine;

public class DGUI : MonoBehaviour
{
    public CanvasGroup DGStartScreenCanvas;
    public CanvasGroup DGGameOverCanvas;
    public CanvasGroup DGGameWonCanvas;


    public void HideDGGameWonCanvas()
    {
        CanvasGroupDisplayer.Hide(DGGameWonCanvas);
    }

    public void ShowDGGameWonCanvas()
    {
        CanvasGroupDisplayer.Show(DGGameWonCanvas);
    }
    
    public void HideDGStartScreenCanvas()
    {
        CanvasGroupDisplayer.Hide(DGStartScreenCanvas);
    }

    public void HideDGGameOverCanvas()
    {
        CanvasGroupDisplayer.Hide(DGGameOverCanvas);
    }

    public void ShowDGStartScreenCanvas()
    {
        CanvasGroupDisplayer.Show(DGStartScreenCanvas);
    }

    public void ShowDGGameOverCanvas()
    {
        CanvasGroupDisplayer.Show(DGGameOverCanvas);
    }
}
