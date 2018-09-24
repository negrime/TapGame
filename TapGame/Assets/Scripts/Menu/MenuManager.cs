using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour 
{

    public GameObject menuManager;
    public Generator generator;
    public Player player;
    public Text languageTxt;
    public int language;
    private string languageStr;

    private void Start()
    {
        language = 1;
    }

    private void Update()
    {
        languageTxt.text = "Language: " + languageStr;
    }

    public void OnPlayClick()
    {
        //menuManager.SetActive(false);
        generator.isGenerate = true;
        player.isRun = true;
        player.globalSpeed = player.speed;
    }

    public void OnSharpClick()
    {
        language = 1; // c#
        languageStr = "C#";
    }

    public void OnDelphiClick()
    {
        language = 2; // delphi
        languageStr = "Delphi";
    }
}
