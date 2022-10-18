using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private Text score;
    private int count;
    public int clear = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.score = GameObject.Find("Score").GetComponent<Text>();
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.score.text == "5")
        {
            clear = 1;
        }
    }

    public void IncScore()
    {
        count += 1;
        this.score.text = count.ToString();
    }
}
