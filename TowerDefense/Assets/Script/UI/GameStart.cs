using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameStart : MonoBehaviour
{
    public Button buttonStart;
    public Button buttonQuit;


   public  void StartGame()
    {
        SceneManager.LoadScene("Quan");
    }

    public void QuitGame()
    {
        // end program
     //  UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }


}
