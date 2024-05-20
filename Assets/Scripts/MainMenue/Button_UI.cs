using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_UI : MonoBehaviour
{
    public void OnClick_PlayButton()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void OnClick_AMXButton()
    {
        Application.OpenURL("https://l.instagram.com/?u=https%3A%2F%2Flinktr.ee%2Famxteam&e=AT2eO4mFy63h6t7F206oKOkWJ_QgI 5DydwYf3YczNDGDbMczVGV73vw6Q9vyMFks0uwaLTE8L9mBFf1yY5o42qplHMDff_g0RX-knvQ");
        Debug.Log("AMX Button is Pressed");
    }
}
