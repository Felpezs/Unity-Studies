using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void ExitApp(){
        Debug.Log("Exited the game");
        Application.Quit();
    }
}
