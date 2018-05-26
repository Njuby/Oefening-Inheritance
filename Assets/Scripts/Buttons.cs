﻿using System;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

    public Animal[] animals;
    
    public Button giveLeaves,
        giveMeat,
        doTricks,
        sayHello;

    public InputField nameField;

    private string inputName;

    //get all buttons to work
    private void Start()
    {
        giveLeaves = giveLeaves.GetComponent<Button>();
        giveLeaves.onClick.AddListener(OnClickLeaves);
        giveMeat = giveMeat.GetComponent<Button>();
        giveMeat.onClick.AddListener(OnClickMeats);
        doTricks = doTricks.GetComponent<Button>();
        doTricks.onClick.AddListener(OnClickTricks);
        sayHello = sayHello.GetComponent<Button>();
        sayHello.onClick.AddListener(OnClickHello);
        animals = FindObjectsOfType<Animal>();

    }

    private void Update()
    {
        inputName = nameField.text;
        Debug.Log(inputName);
        
    }

    private void OnClickHello()
    {
        Debug.Log("click");
        foreach(Animal a in animals)
        {
            a.SayHello();
        }
    }

    private void OnClickTricks()
    {
        foreach (Animal a in animals)
        {
            a.PerformTrick();
        }
    }

    private void OnClickMeats()
    {
        foreach (Animal a in animals)
        {
            a.EatMeat();
        }
    }

    private void OnClickLeaves()
    {
        foreach (Animal a in animals)
        {
            a.EatLeaves();
        }
    }

   

}
