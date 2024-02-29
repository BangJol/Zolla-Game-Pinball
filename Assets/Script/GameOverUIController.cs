using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
  private void Start()
  {

  }

  public void MainMenu()
  {
    SceneManager.LoadScene("MainMenu");
  }
}
