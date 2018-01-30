using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControll : MonoBehaviour {

    public void changeMenuScene(string scenename)
    {
        Application.LoadLevel(scenename);
    }


    public void closeGame()
    {
        Application.Quit();
    }
}
