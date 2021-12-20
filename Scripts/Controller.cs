using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Controller : MonoBehaviour
{
    public UpgradeManager upgradeManager;
    public skillTree skillTree;
    public TMP_Text o2_text;
    public Data data;
    public Upgrades Upgrade;
    public Image clickImage;
    public Image autoUpgrade1Image;
    public Image autoUpgrade2Image;
    public Image autoUpgrade3Image;
    public Image autoUpgrade4Image;
    public Image autoUpgrade5Image;

    public Image buy1GemImage;

    private void Awake()
    {
        //PlayerPrefs.DeleteAll();
    }

    public void Start()
    {    
        data = new Data();
        upgradeManager.startManager();        
    }
    public  double clickPower()
    {
        return 1 + Data.clickUpgradeLevel * skillTree.skill1Level;
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void Update()
    {       
        o2_text.text = Mathf.Round((float)Data.o2).ToString();

        if (upgradeManager.clickCost() > Data.o2)
        {
            clickImage.GetComponent<Image>().color = new Color32(150, 150, 150, 255);
        }
        else
        {
            clickImage.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if (upgradeManager.autoCost1() > Data.o2)
        {
            autoUpgrade1Image.GetComponent<Image>().color = new Color32(150, 150, 150, 255);
        }
        else
        {
            autoUpgrade1Image.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if (upgradeManager.autoCost2() > Data.o2)
        {
            autoUpgrade2Image.GetComponent<Image>().color = new Color32(150, 150, 150, 255);
        }
        else
        {
            autoUpgrade2Image.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if (upgradeManager.autoCost3() > Data.o2)
        {
            autoUpgrade3Image.GetComponent<Image>().color = new Color32(150, 150, 150, 255);
        }
        else
        {
            autoUpgrade3Image.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if (upgradeManager.autoCost4() > Data.o2)
        {
            autoUpgrade4Image.GetComponent<Image>().color = new Color32(150, 150, 150, 255);
        }
        else
        {
            autoUpgrade4Image.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if (upgradeManager.autoCost5() > Data.o2)
        {
            autoUpgrade5Image.GetComponent<Image>().color = new Color32(150, 150, 150, 255);
        }
        else
        {
            autoUpgrade5Image.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        
    }
    public void o2Click()
    {
        Data.o2 += clickPower();
        Debug.Log(skillTree.skill1Level);
    }   
}
