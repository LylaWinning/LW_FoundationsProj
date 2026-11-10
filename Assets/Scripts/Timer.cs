using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    //[SerializeField] private TextMeshProUGUI timer_Txt;
   // [SerializeField] private TextMeshProUGUI win_Lose_Txt;
    [SerializeField] private float time_Left;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine(timer_Count());

    }


    IEnumerator timer_Count()
    {
        time_Left--;
        UpdateTime();

        if(time_Left <= 0)
        {
            Debug.Log("Time's Up!");
            UIHandler.Instance.win_Lose_Msg.gameObject.SetActive(true);
            UIHandler.Instance.win_Lose_Msg.text = "You didn't capture all the ghosts in time! You Lose!";
            UIHandler.Instance.On_Mission_Failed_Event.Invoke();
            time_Left = 0;
            StopTimer();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
          
        }

        yield return new WaitForSeconds(1);
        StartCoroutine(timer_Count());
    }

    private void UpdateTime()
    {
        int min = Mathf.FloorToInt(time_Left / 60);
        int sec = Mathf.FloorToInt(time_Left % 60);

        UIHandler.Instance.timer_Txt.text = min.ToString("00") + ":"  + sec.ToString("00");
    }

    public void StopTimer()
    {
        StopAllCoroutines();
    }

}
