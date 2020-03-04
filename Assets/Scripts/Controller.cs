using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Controller : MonoBehaviour
{
    private string scene,weather,time;

    [SerializeField] private Dropdown dropdownScene;
    [SerializeField] private Dropdown dropdownWeather;
    [SerializeField] private Dropdown dropdownTime;
    // Start is called before the first frame update
    void Start()
    {
        //NAO USAR O PLAYERPREFABS, 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click()
    {
        weather = dropdownWeather.options[dropdownWeather.value].text;
        scene = dropdownScene.options[dropdownScene.value].text;
        time = dropdownTime.options[dropdownTime.value].text;
        Debug.Log(weather + " " + scene + " " + time);
        SceneManager.LoadScene(scene + "Scene");
    }
}
