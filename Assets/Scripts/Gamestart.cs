using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamestart : MonoBehaviour
{
    public void SceneChanged()
    {
        SceneManager.LoadScene("GameSc");
    }
}
