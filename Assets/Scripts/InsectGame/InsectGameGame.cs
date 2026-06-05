using UnityEngine;

public class InsectGameGame : MonoBehaviour
{
    public InsectGameInsectSpawner InsectGameInsectSpawner;
    
    void Start()
    {
        InsectGameInsectSpawner.StartPlacing();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
