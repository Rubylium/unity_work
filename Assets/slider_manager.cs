using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class slider_manager : MonoBehaviour
{
    public Slider volume_slider;

    private GameObject txt_volume;
    private GameObject slider_volume;

    private Component slider;
    // Start is called before the first frame update
    void Start()
    {
        txt_volume = GameObject.Find("txt_volume");
        slider_volume = GameObject.Find("slider_volume");

        slider_volume.GetComponent<Slider>().value = PlayerPrefs.GetFloat("volume");
    }

    // Update is called once per frame
    void Update()
    {
        float volume = slider_volume.GetComponent<Slider>().value;
        txt_volume.GetComponent<TextMeshProUGUI>().text = (volume * 100).ToString() + "%" ;
        PlayerPrefs.SetFloat("volume", volume);
    }
}
