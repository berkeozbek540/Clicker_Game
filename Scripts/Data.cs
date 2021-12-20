using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{

    public static double o2;
    public static double o2perSecond;
    public static double clickUpgradeLevel;
    public static double autoUpgradeLevel1;
    public static double autoUpgradeLevelX1;
    public static double autoUpgradeLevel2;
    public static double autoUpgradeLevelX2;
    public static double autoUpgradeLevel3;
    public static double autoUpgradeLevelX3;
    public static double autoUpgradeLevel4;
    public static double autoUpgradeLevelX4;
    public static double autoUpgradeLevel5;
    public static double autoUpgradeLevelX5;

    public Data()
    {
        PlayerPrefs.GetInt("o2",(int)o2);
        PlayerPrefs.GetInt("o2persec", (int)o2perSecond);
        PlayerPrefs.GetInt("clickUpgradeLevel",(int)clickUpgradeLevel);
        PlayerPrefs.GetInt("autoUpgradeLevel1",(int)autoUpgradeLevel1);
        PlayerPrefs.GetInt("autoUpgradeLevelX1", (int)autoUpgradeLevelX1);
        PlayerPrefs.GetInt("autoUpgradeLevel2",(int)autoUpgradeLevel2);
        PlayerPrefs.GetInt("autoUpgradeLevelX2", (int)autoUpgradeLevelX2);
        PlayerPrefs.GetInt("autoUpgradeLevel3", (int)autoUpgradeLevel3);
        PlayerPrefs.GetInt("autoUpgradeLevelX3", (int)autoUpgradeLevelX3);
        PlayerPrefs.GetInt("autoUpgradeLevel4", (int)autoUpgradeLevel4);
        PlayerPrefs.GetInt("autoUpgradeLevelX4", (int)autoUpgradeLevelX4);
        PlayerPrefs.GetInt("autoUpgradeLevel5", (int)autoUpgradeLevel5);
        PlayerPrefs.GetInt("autoUpgradeLevelX5", (int)autoUpgradeLevelX5);
    }


}
   
    

