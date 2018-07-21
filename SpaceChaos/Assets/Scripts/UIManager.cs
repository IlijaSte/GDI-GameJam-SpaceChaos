using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

    public Text Score;
    public int score;

    public static UIManager I;

    private void Start()
    {
        I = this;
        score = 0;
        Score.text = score.ToString();
    }
}
