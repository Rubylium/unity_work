using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class obj_not_take : MonoBehaviour
{
    
    private int score = 0;
    private String score_to_display;
    public AudioClip[] playlist;
    public AudioSource audioSource;

    private void PlayScoreSound()
    {
        audioSource.clip = playlist[0];
        audioSource.volume = 0.2f;
        audioSource.Play(); 
    }
    
    // Update is called once per frame
    void Update()
    {
        
        GameObject obj = GameObject.Find("Mace-Chain");
        
        //Debug.Log("Falling: " + obj.transform.position);
        Vector3 pos = obj.transform.position;   
        if (pos.y < -3.1)
        {
            obj.transform.position = new Vector3(NextFloat(-2, 2), 5,
                obj.transform.position.z);
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, -1f - (score / 3));
            Debug.Log(-1.0f * score);
            score = score + 1;
            PlayerPrefs.SetString("score", score.ToString());
            PlayScoreSound();
            this.UpdateScore();
        }
    }

    private void UpdateScore()
    {
        score_to_display = GameObject.Find("txt_score_display").GetComponent<Text>().text =
            "Score:" + PlayerPrefs.GetString("score");
        int bestScore = PlayerPrefs.GetInt("best_score");
        if (bestScore < score)
        {
            PlayerPrefs.SetInt("best_score", score);
        }
    }

    private void ResetCoinPosition()
    {
        GameObject coin = GameObject.Find("Coin");
        coin.transform.position = new Vector3(NextFloat(-2, 2), 5,
            coin.transform.position.z);
        coin.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        score = score + 5;
        PlayerPrefs.SetString("score", score.ToString());
        UpdateScore();
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Body")
        {
            if (col.otherCollider.name == "Mace-Chain")
            {
                SceneManager.LoadScene("end_screen");  
            }
        }
    }
    
    static float NextFloat(float min, float max){
        System.Random random = new System.Random();
        double val = (random.NextDouble() * (max - min) + min);
        return (float)val;
    }
}
