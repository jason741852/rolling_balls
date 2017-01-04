using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;

    private Rigidbody rb;
    private int count=0;
    private int playerID;

    // accessor
    public int getCount()
    {
        return count;
    }

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        playerID = (int)char.GetNumericValue(this.gameObject.name[6]);
        count = 0;
        SetCountText();
    }
	void FixedUpdate ()
    {
        float moveHorizontal=0;
        float moveVertical=0;

        ///////////////////////////////////////////////////////
        // if you wish to add more players, change this part //
        // and in Unity, go to edit->project setting->input  //
        // to add more axes and add the axes here accordingly//
        ///////////////////////////////////////////////////////
        if (playerID == 1)
        {
            moveHorizontal = Input.GetAxis("P1_Horizontal");
            moveVertical = Input.GetAxis("P1_Vertical");
        }
        else if(playerID == 2)
        {
            moveHorizontal = Input.GetAxis("P2_Horizontal");
            moveVertical = Input.GetAxis("P2_Vertical");
        }

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    void SetCountText ()
    {
       countText.text = this.gameObject.name + " Count: " + count.ToString();
    }
}
