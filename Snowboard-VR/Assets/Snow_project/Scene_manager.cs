using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_manager : MonoBehaviour
{
   public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(1);
    }
}
