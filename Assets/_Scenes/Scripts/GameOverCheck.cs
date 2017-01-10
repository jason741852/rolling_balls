using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverCheck : MonoBehaviour {
    public Text GameOverText;
    public Button MenuButton;
    public Button RestartButton;
    public Button NextLevelButton;

    private GameObject[] Players;
    private GameObject[] Buttons;
    private int PickupsNumber;
    private int TotalCount;
    private int Count;
    private int prevCount;
    private string WinningPlayerName;
	// Use this for initialization
	void Start () {
        Players = GameObject.FindGameObjectsWithTag("Player");
        PickupsNumber = GameObject.FindGameObjectsWithTag("Pick Up").Length;
        Debug.Log(PickupsNumber);
    }
	
	// Update is called once per frame
	void Update () {
        TotalCount = 0;
        prevCount = 0;
        foreach (GameObject player in Players)
        {
            Count = player.GetComponent<PlayerController>().getCount();
            if(Count > prevCount)
            {
                WinningPlayerName = player.name;
            }
            TotalCount += Count;
            prevCount = Count;

            
        }
        if (TotalCount == PickupsNumber)
        {
            GameOverText.text = WinningPlayerName + " wins!";
        }
    }
}
