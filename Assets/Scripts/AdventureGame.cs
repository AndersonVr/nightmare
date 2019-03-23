using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] Image imageComponent;
    [SerializeField] State startingState;
    [SerializeField] Button[] buttonComponents;

    State state;

    void Start()
    {
        LoadState(startingState);
    }

    void LoadState(State state)
    {
        this.state = state;
        textComponent.text = state.GetStateStory();
        imageComponent.sprite = state.ImageStateStory();

        for (int i = 0; i < buttonComponents.Length; i++)
        {
            if (state.GetSwitchInfo() !=null && i < state.GetSwitchInfo().Length)
            {
                buttonComponents[i].gameObject.SetActive(true);
                buttonComponents[i].GetComponentInChildren<Text>().text = state.GetSwitchInfo()[i].buttonTxt;
            }
            else
            {
                buttonComponents[i].gameObject.SetActive(false);
            }
        }
    }

    public void ChangeState(int index)
    {
        LoadState(state.GetSwitchInfo()[index].targetState);
    }
}
