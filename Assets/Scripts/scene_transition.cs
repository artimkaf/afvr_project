using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class scene_transition : MonoBehaviour
{
    public int scene;
    public void changeScene()
    {
        SceneManager.LoadScene(scene);
    }
}
