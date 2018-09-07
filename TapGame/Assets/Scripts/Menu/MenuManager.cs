using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public GameObject menuManager;
    public Generator generator;
    public Player player;
  

    public void OnPlayClick()
    {
        //menuManager.SetActive(false);
        generator.isGenerate = true;
        player.isRun = true;
        player.globalSpeed = player.speed;
        player.health = 10;
    }
	




}
