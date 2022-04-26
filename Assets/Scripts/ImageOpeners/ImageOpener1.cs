using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ImageOpener1 : MonoBehaviour
{
    string path;
    public RawImage rawImage;


    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        rawImage = data.rawImage;
    }

    public void OpenFileExplorer()
    {
       
        path = EditorUtility.OpenFilePanel("Show all images (.png)", "", "png");
        StartCoroutine(getTexture());
    }


    IEnumerator getTexture()
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture("file:///" + path);

        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Texture myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            rawImage.texture = myTexture;
        }

    }
    


}
