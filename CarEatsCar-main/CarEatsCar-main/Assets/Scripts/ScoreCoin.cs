using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCoin : MonoBehaviour
{
    public TextMeshProUGUI MyscoreText;
    private int ScoreNum;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        UpdateScoreText();
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "MyCoin")
        {
            ScoreNum += 1;
            Destroy(Coin.gameObject);
            MyscoreText.text = ":" + ScoreNum;
        }
    }

    // Update the score text
    private void UpdateScoreText()
    {
        MyscoreText.text = ": " + ScoreNum;
    }
}
