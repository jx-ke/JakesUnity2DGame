using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
        SceneManager.LoadScene(4);
        }
    }

    // Update is called once per frame
}
