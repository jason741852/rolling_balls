using UnityEngine;
using System.Collections;


public class LoadLevel1 : MonoBehaviour {

	public void LoadLevel()
    {
        Debug.Log("lv1 clicked");
        Application.LoadLevel(1);
    }
}
