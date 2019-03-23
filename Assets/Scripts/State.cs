using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(14, 10)] [SerializeField] string storyText;
    [SerializeField] Sprite image;
    [SerializeField] StateSwitchInfo[] switchInfo;

    public string GetStateStory()
    {
        return storyText;
    }

    public StateSwitchInfo[] GetSwitchInfo() 
    {
        return switchInfo;
    }

    public Sprite ImageStateStory()
    {
        return image;
    }
}
