using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
  public void PlayGame()
  {
    SceneManager.LoadScene("Pinball Game");
  }

  public void ExitGame()
  {
    Application.Quit();
  }

  public void Credit()
  {
    SceneManager.LoadScene("Credit");
  }
}
