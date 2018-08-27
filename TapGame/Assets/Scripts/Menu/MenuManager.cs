using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public GameObject menuManager;
    public Generator generator;
  

    public void OnPlayClick()
    {
        //menuManager.SetActive(false);
        generator.isGenerate = true;

    }
	




}
