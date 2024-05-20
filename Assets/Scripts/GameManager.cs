using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float timeScale = 1;
    private void Start()
    {
        Application.targetFrameRate = 144;

        InvokeRepeating(nameof(Set_FastTimer), 5f, 5f);
    }

    private void Set_FastTimer()
    {
        Time.timeScale = timeScale;
        timeScale = timeScale + .1f;
        Debug.Log(timeScale);
    }
}
