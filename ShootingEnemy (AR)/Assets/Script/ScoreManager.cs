using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    Text ScoreTxt;


    // Start is called before the first frame update
    void Start()
    {
        ScoreTxt = GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTxt.text = "" + score;

        if (score == 1000)
        {
            SceneManager.LoadScene(1);
            Debug.Log("WINNER");
        }
    }

}
