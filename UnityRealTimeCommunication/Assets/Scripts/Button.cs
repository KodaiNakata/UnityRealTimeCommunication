using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// ボタンのクリック処理
    /// </summary>
    /// <param name="sceneName">画面名</param>
    public void onClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
