using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class obj_not_take : MonoBehaviour
{
    
    private int score = 0;
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
            obj.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            score = score + 1;
            Debug.Log(score);
            PlayerPrefs.SetString("score", score.ToString());
            
        }
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision");
        SceneManager.LoadScene("end_screen");
    }
    
    static float NextFloat(float min, float max){
        System.Random random = new System.Random();
        double val = (random.NextDouble() * (max - min) + min);
        return (float)val;
    }
}
