using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public GameObject restartButton;

    public void Restart()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene("AR Treasure Hunt");
    }
}