using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>().clear;
        if (score == 1)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
