using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] public Text textComponent;
    [SerializeField] public Image imageComponent;
    [SerializeField] public MotherState startingState;
    [SerializeField] public Button[] buttonComponents;

    void Start()
    {
        LoadMotherState(startingState);
    }

    public void LoadMotherState(MotherState motherState)
    {
        motherState.LoadState(this);        
    }

}
