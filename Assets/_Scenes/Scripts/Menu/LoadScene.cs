using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public void LoadLevel()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene("MiniGame");
        Debug.Log("button clicked");
        Application.LoadLevel(1);
    }
}
