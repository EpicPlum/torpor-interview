using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class switchScenes : MonoBehaviour
{
    public void Notes()
    {
        SceneManager.LoadScene("Notes");
    }

    public void Codex()
    {
        SceneManager.LoadScene("Codex");
    }

}
