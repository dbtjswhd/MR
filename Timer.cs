using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float startNum;
    private float nowNum;
    private float endNum;
    public TMP_Text timeText;

    void Start()
    {
        startNum = Time.time;
        timeText.text = "Time : " + startNum;
    }

    void Update()
    {
        timeCheck();
    }

    void timeCheck()
    {
        nowNum = Time.time - startNum;
        
        float roundedTime = Mathf.Round(nowNum * 10f) / 10f;
        
        timeText.text = "Time : " + roundedTime;

        //endNum 코드 작성 부분
    }
}
