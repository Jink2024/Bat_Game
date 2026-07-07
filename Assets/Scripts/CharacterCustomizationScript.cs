using System;
using System.Diagnostics;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class CharacterCustomizationScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite brownBat;
    public Sprite greyBat;
    public Sprite blackBat;
    
    public TMP_InputField nameField;

    // Player name variable and property to access
    // it from other scripts.
    string playerName;
    
    public string PlayerName
    {
        get{ return playerName; }
        set{ Debug.Log("You are not allowed to set the player name like that"); }
    }

    //Use this on a "Submit" button to set the playerName variable.
    public void SubmitName()
    {
        
        nameField.text = PlayerName;
        if(string.IsNullOrEmpty(nameField.text) == false)
        {
            playerName = nameField.text;
        }
    }
    
    public void OnClickChangeToBrown()
    {
        spriteRenderer.sprite = brownBat;
        spriteRenderer.transform.position = new Vector3(2.1f, -.7f,0);
        spriteRenderer.transform.localScale = new Vector3(13f, 13f, 0);
    }
    
    public void OnClickChangeToGrey()
    {
        spriteRenderer.sprite = greyBat;
        spriteRenderer.transform.position = new Vector3(2.1f, -.5f,0);
        spriteRenderer.transform.localScale = new Vector3(2.5f, 2.5f, 0);
    }
    
    public void OnClickChangeToBlack()
    {
        spriteRenderer.sprite = blackBat;
        spriteRenderer.transform.position = new Vector3(2.1f, -.5f,0);
        spriteRenderer.transform.localScale = new Vector3(2.5f, 2.5f, 0);
    }
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
