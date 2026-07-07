using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class TeachingScene : MonoBehaviour
{
    public CanvasGroup DietCanvas;
    public UI UI;
    public GameObject DietMedal;
    public GameObject HabitatMedal;
    public GameObject BatExpertMedal;

    public bool hasDietMedal = false;
    public bool hasHabitatMedal = false;
    public bool hasBatExpertMedal = false;
    
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       ResetTeachingScene();
       UI.HideTeachingOverButtons();
       UI.ShowTeachingButtons();
    }
    

    public void OnClickShowDiet()
    {
        UI.ShowDiet();
        UI.HideTeachingButtons();
    }

    public void OnClickHideDiet()
    {
        UI.HideDiet();
        UI.ShowTeachingButtons();
        
        
        Instantiate(DietMedal, new Vector3(-6.5f, 2.3f, 0), Quaternion.identity);
        DietMedal.transform.position = new Vector3(-6.5f, 2.3f, 0);
        DietMedal.transform.localScale = new Vector3(6, 6, 1);
        hasDietMedal = true;
    }
    
    public void OnClickShowHabitat()
    {
        UI.ShowHabitat();
        UI.HideTeachingButtons();
    }

    public void OnClickHideHabitat()
    {
        UI.HideHabitat();
        UI.ShowTeachingButtons();
        
        Instantiate(HabitatMedal, new Vector3(-6.5f, .3f, 0), Quaternion.identity);
        HabitatMedal.transform.position = new Vector3(-6.5f, .3f, 0);
        HabitatMedal.transform.localScale = new Vector3(6, 6, 1);
        hasHabitatMedal = true;
    }
    
    public void OnClickShowFacts()
    {
        UI.ShowFacts();
        UI.HideTeachingButtons();
    }

    public void OnClickHideFacts()
    {
        UI.HideFacts();
        UI.ShowTeachingButtons();
        
        Instantiate(BatExpertMedal, new Vector3(-6.5f, -1.7f, 0), Quaternion.identity);
        BatExpertMedal.transform.position = new Vector3(-6.5f, -1.7f, 0);
        BatExpertMedal.transform.localScale = new Vector3(6, 6, 1);
        hasBatExpertMedal = true;
    }

    public void TeachingOver()
    {
        if (hasDietMedal && hasHabitatMedal && hasBatExpertMedal)
        {
            ResetTeachingScene();
            UI.HideTeachingButtons();
            
            UI.ShowTeachingOverButtons();
            // make button appear that allows you to go to main menu?
        }
    }

    public void ResetTeachingScene()
    {
        UI.HideDiet();
        UI.HideHabitat();
        UI.HideFacts();
        
        hasDietMedal = false;
        hasHabitatMedal = false;
        hasBatExpertMedal = false;
        
        if (gameObject.CompareTag("Medal"))
        {
            Destroy(gameObject);
        }
        
    }
    
    // Update is called once per frame
    void Update()
    {
       TeachingOver(); 
    }
}
