using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
    }
}