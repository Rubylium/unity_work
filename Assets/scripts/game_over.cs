using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class game_over : MonoBehaviour
{
    private String _title;
    
    private void Start()
    {
        Debug.Log("Score finals: " + PlayerPrefs.GetString("score"));
        GameObject.Find("txt_score").GetComponent<TextMeshProUGUI>().text = "Score:" + PlayerPrefs.GetString("score");
        GameObject.Find("txt_score_best").GetComponent<TextMeshProUGUI>().text = "Best score:" + PlayerPrefs.GetInt("best_score");
    }
}
