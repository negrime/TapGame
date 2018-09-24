using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class WordGenerator : MonoBehaviour
{

	private MenuManager menu;
	private int caze;
	
	private  string[] csharpList = {"private", "public", "protected", "void", "while", "if", "else", "const", "new" };
	private  string[] delphiList = {"begin", "end", "for", "to", "integer"};


	/*private void Start()
	{
		caze = menu.language;
		menu = FindObjectOfType<MenuManager>();
	}

	private void Update()
	{
		caze = menu.language;
	}


/*	public string ListChoose()
	{
		string result;
		int randomIndex;
		switch (caze)
		{
			case 1 :
				randomIndex = Random.Range(0, csharpList.Length);
				result = csharpList[randomIndex];
				break;;
			case 2 :
				randomIndex = Random.Range(0, delphiList.Length);
				result = delphiList[randomIndex];
				break;
			default:
				result = "k";
				break;
		}

		return result;
	} */

	public  static string GetRandomWord ()
	{
		string result;
		int randomIndex;
		
		
	//	int randomIndex = Random.Range(0, kek.Length);
		//string randomWord = Lis;
		//Debug.Log(kek[1]);

		//return ;
		return "kek";
	} 


}
