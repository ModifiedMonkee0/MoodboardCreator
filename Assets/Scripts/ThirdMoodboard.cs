using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdMoodboard : MonoBehaviour
{
    public void thirdMoodboard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +3);
    }

    public void thirdMoodboardBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -3);
    }
}