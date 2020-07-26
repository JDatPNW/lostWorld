using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Collect : MonoBehaviour {

    public int remaining;
    public Text remainingText;
    public Text winningText;

	// Use this for initialization
	void Start () {
        remaining = 3;
        SetRemainingText();
        winningText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider coins)
    {
        if (coins.gameObject.CompareTag("Coin"))
            Destroy(coins.gameObject);
        //coins.gameObject.SetActive(false);
        remaining--;
        SetRemainingText();
    }

    void SetRemainingText()
    {
        remainingText.text = "Coins Remaining: " + remaining.ToString();
        if (remaining <= 0)
            winningText.text = "The Cube has launched!";
    }

}
