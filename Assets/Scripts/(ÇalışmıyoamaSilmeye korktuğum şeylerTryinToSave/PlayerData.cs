using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class PlayerData 
{
    public RawImage rawImage;
    public InputField inputField;

        public PlayerData(ImageOpener1 player)
    {
        rawImage = player.rawImage;
    }
}
