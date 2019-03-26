using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] Image imageComponent;
    [SerializeField] MotherState startingState;
    [SerializeField] Button[] buttonComponents;

    MotherState motherState;

    void Start()
    {
        this.motherState = startingState;
        LoadState(startingState);
    }

    public void LoadState(MotherState motherState)
    {
        motherState.LoadStates(textComponent, imageComponent, buttonComponents);
    }
}
