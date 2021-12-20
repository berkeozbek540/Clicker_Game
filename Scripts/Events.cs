using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
{
    public bool nowisEvent;
    public GameObject goldButton;

    private void Update()
    {
        if(nowisEvent == false && goldButton.active == true)
        {
            goldButton.SetActive(false);
            StartCoroutine(waitForEvent());
        }
        if(nowisEvent == true && goldButton.active == false)
        {
            goldButton.SetActive(true);
        }
    }

    public void getReward()
    {
        Data.o2 = Data.o2 + (Data.o2perSecond * 60);
        nowisEvent = false;
        StartCoroutine(waitForEvent());
    }
    IEnumerator waitForEvent()
    {
        yield return new WaitForSeconds(8f);
        int x = 0;
        x = Random.Range(1, 3);

        if(x == 2)
        {
            nowisEvent = true;
        }
        else
        {
            goldButton.SetActive(true);
        }
    }
}


