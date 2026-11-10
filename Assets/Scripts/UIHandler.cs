using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class UIHandler : MonoBehaviour
{


public static UIHandler Instance;

public TextMeshProUGUI score_txt;
public TextMeshProUGUI win_Lose_Msg;
public TextMeshProUGUI timer_Txt;

[Space(20)]

public GameObject mission_Complete_Panel;
public GameObject mission_Failed_Panel;

public UnityEvent On_Mission_Complete_Event;
public UnityEvent On_Mission_Failed_Event;

internal object levels;


private void Awake()
    {
        Instance = this;
        On_Mission_Complete_Event.AddListener(delegate { LevelComplete(); });
        On_Mission_Failed_Event.AddListener(delegate { LevelFailed(); });
    }

    private void LevelComplete()
    {
        StartCoroutine(show_Level_Complete());

    }

    private void LevelFailed()
    {
       StartCoroutine(show_Level_Failed());

    }


    IEnumerator show_Level_Complete()
    {
        win_Lose_Msg.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        win_Lose_Msg.gameObject.SetActive(false);
        mission_Complete_Panel.SetActive(true);
    }

IEnumerator show_Level_Failed()
    {
        win_Lose_Msg.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        win_Lose_Msg.gameObject.SetActive(false);
        mission_Failed_Panel.SetActive(true);
    }
    public void Restart_Level()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ClickToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
