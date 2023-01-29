using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
public class Clock : MonoBehaviour
{
    public float Sec;
    public float Hourse;
    public float Min;
    public int GameDay;

    string stringSec;
    string stringMin;
    string stringDay;

    public TextMeshProUGUI TextTime;
    public TextMeshProUGUI Day;
    

    void Update()
    {
        Sec = Sec + Time.deltaTime;

        stringSec = Sec.ToString();
        stringMin = Hourse.ToString();
        stringDay = GameDay.ToString();

        TextTime.text = stringMin + ":" + Min;
        Day.text = stringDay + "\nDay";
        
        if(Sec >=1.0f)
        {
            Min = Min + 1.0f;
            Sec = 0.0f;
        }

        if(Min >= 60.0f)
        {
            Hourse = Hourse + 1.0f;
            Min = 0.0f;
        }

        if (Hourse >= 24.0f)
        {
            GameDay++;
            Hourse = 0.0f;
        }

        
    }
}