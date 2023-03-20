using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public void LoadMainMenu() => SceneManager.LoadScene(0);

    public void LoadGame() => SceneManager.LoadScene(1);

    public void LoadGameOverScreen() => SceneManager.LoadScene(2);
}
