using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_over : MonoBehaviour
{
    [SerializeField] 
    private Text _title;
    

    private void Start()
    {
        Debug.Log("Score final: " + PlayerPrefs.GetString("score"));
        _title.GetComponent<Text>().text = PlayerPrefs.GetString("score");
    }
}
