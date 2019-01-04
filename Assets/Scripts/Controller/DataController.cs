using UnityEngine;
using System.Collections;

public class DataController
{

    private static string TAG_HIGHTSCORE = "hightLevel";
    private static string TAG_HIGHTSECOND = "hightSecond";
    private static string TAG_NAME = "myname";
    private static string TAG_MAC = "mymac";
    private static string TAG_TOP = "mytop";


    private static string TAG_HIGHTLEVEL_VIO1 = "lvf1";
    private static string TAG_HIGHTCOIN_VIO1 = "scf1";

    private static string TAG_HIGHTLEVEL_VIO2 = "lvf2";
    private static string TAG_HIGHTCOIN_VIO2 = "scf2";

    private static string TAG_HIGHTLEVEL_VIO3 = "lvf3";
    private static string TAG_HIGHTCOIN_VIO3 = "scf3";

    private static string TAG_HIGHTLEVEL_VIO4 = "lvf4";
    private static string TAG_HIGHTCOIN_VIO4 = "scf4";

    private static string TAG_HIGHTLEVEL_VIO5 = "lvf5";
    private static string TAG_HIGHTCOIN_VIO5 = "scf5";


    //-------------------------------------------

    //lay lai gia tri chuoi diem tung level da vuot qua.

    public static string GetHightStringCoinVio5()
    {
        if (PlayerPrefs.HasKey(TAG_HIGHTCOIN_VIO5))
        {
            return PlayerPrefs.GetString(TAG_HIGHTCOIN_VIO5);
        }
        else
        {
            return "1+2+3+4+5+6+7+8+9+10+11+12+13+14+15+16+17+18+19+20";
        }
    }

    //luu lai gia tri chuoi diem tung level da vuot qua.
    public static void SaveHightStringCoinVio5(string newHightScore)
    {
        PlayerPrefs.SetString(TAG_HIGHTCOIN_VIO5, newHightScore);
    }

    //lay lai gia tri level da vuot qua.
    public static int GetHightLevelVio5()
    {
        if (PlayerPrefs.HasKey(TAG_HIGHTLEVEL_VIO5))
        {
            return PlayerPrefs.GetInt(TAG_HIGHTLEVEL_VIO5);
        }
        else
        {
            return 0;
        }
    }

    //luu lai gia tri level da vuot qua.
    public static void SaveHightLevelVio5(int newHightScore)
    {
        PlayerPrefs.SetInt(TAG_HIGHTLEVEL_VIO5, newHightScore);
    }



    //-------------------------------------------

    //lay lai gia tri chuoi diem tung level da vuot qua.

    public static string GetHightStringCoinVio4()
    {
        if (PlayerPrefs.HasKey(TAG_HIGHTCOIN_VIO4))
        {
            return PlayerPrefs.GetString(TAG_HIGHTCOIN_VIO4);
        }
        else
        {
            return "1+2+3+4+5+6+7+8+9+10+11+12+13+14+15+16+17+18+19+20";
        }
    }

    //luu lai gia tri chuoi diem tung level da vuot qua.
    public static void SaveHightStringCoinVio4(string newHightScore)
    {
        PlayerPrefs.SetString(TAG_HIGHTCOIN_VIO4, newHightScore);
    }

    //lay lai gia tri level da vuot qua.
    public static int GetHightLevelVio4()
    {
        if (PlayerPrefs.HasKey(TAG_HIGHTLEVEL_VIO4))
        {
            return PlayerPrefs.GetInt(TAG_HIGHTLEVEL_VIO4);
        }
        else
        {
            return 0;
        }
    }

    //luu lai gia tri level da vuot qua.
    public static void SaveHightLevelVio4(int newHightScore)
    {
        PlayerPrefs.SetInt(TAG_HIGHTLEVEL_VIO4, newHightScore);
    }


    //-------------------------------------------

    //lay lai gia tri chuoi diem tung level da vuot qua.

    public static string GetHightStringCoinVio3()
    {
        if (PlayerPrefs.HasKey(TAG_HIGHTCOIN_VIO3))
        {
            return PlayerPrefs.GetString(TAG_HIGHTCOIN_VIO3);
        }
        else
        {
            return "1+2+3+4+5+6+7+8+9+10+11+12+13+14+15+16+17+18+19+20";
        }
    }

    //luu lai gia tri chuoi diem tung level da vuot qua.
    public static void SaveHightStringCoinVio3(string newHightScore)
    {
        PlayerPrefs.SetString(TAG_HIGHTCOIN_VIO3, newHightScore);
    }

    //lay lai gia tri level da vuot qua.
    public static int GetHightLevelVio3()
    {
        if (PlayerPrefs.HasKey(TAG_HIGHTLEVEL_VIO3))
        {
            return PlayerPrefs.GetInt(TAG_HIGHTLEVEL_VIO3);
        }
        else
        {
            return 0;
        }
    }

    //luu lai gia tri level da vuot qua.
    public static void SaveHightLevelVio3(int newHightScore)
    {
        PlayerPrefs.SetInt(TAG_HIGHTLEVEL_VIO3, newHightScore);
    }

    //-------------------------------------------

    //lay lai gia tri chuoi diem tung level da vuot qua.

    public static string GetHightStringCoinVio2()
    {
        if (PlayerPrefs.HasKey(TAG_HIGHTCOIN_VIO2))
        {
            return PlayerPrefs.GetString(TAG_HIGHTCOIN_VIO2);
        }
        else
        {
            return "1+2+3+4+5+6+7+8+9+10+11+12+13+14+15+16+17+18+19+20";
        }
    }

    //luu lai gia tri chuoi diem tung level da vuot qua.
    public static void SaveHightStringCoinVio2(string newHightScore)
    {
        PlayerPrefs.SetString(TAG_HIGHTCOIN_VIO2, newHightScore);
    }

    //lay lai gia tri level da vuot qua.
    public static int GetHightLevelVio2()
    {
        if (PlayerPrefs.HasKey(TAG_HIGHTLEVEL_VIO2))
        {
            return PlayerPrefs.GetInt(TAG_HIGHTLEVEL_VIO2);
        }
        else
        {
            return 0;
        }
    }

    //luu lai gia tri level da vuot qua.
    public static void SaveHightLevelVio2(int newHightScore)
    {
        PlayerPrefs.SetInt(TAG_HIGHTLEVEL_VIO2, newHightScore);
    }


    //-------------------------------------------

    //lay lai gia tri chuoi diem tung level da vuot qua.

    public static string GetHightStringCoinVio1()
    {
        if (PlayerPrefs.HasKey(TAG_HIGHTCOIN_VIO1))
        {
            return PlayerPrefs.GetString(TAG_HIGHTCOIN_VIO1);
        }
        else
        {
            return "1+2+3+4+5+6+7+8+9+10+11+12+13+14+15+16+17+18+19+20";
        }
    }

    //luu lai gia tri chuoi diem tung level da vuot qua.
    public static void SaveHightStringCoinVio1(string newHightScore)
    {
        PlayerPrefs.SetString(TAG_HIGHTCOIN_VIO1, newHightScore);
    }

    //lay lai gia tri level da vuot qua.
    public static int GetHightLevelVio1()
    {
        if (PlayerPrefs.HasKey(TAG_HIGHTLEVEL_VIO1))
        {
            return PlayerPrefs.GetInt(TAG_HIGHTLEVEL_VIO1);
        }
        else
        {
            return 0;
        }
    }

    //luu lai gia tri level da vuot qua.
    public static void SaveHightLevelVio1(int newHightScore)
    {
        PlayerPrefs.SetInt(TAG_HIGHTLEVEL_VIO1, newHightScore);
    }



    public static int GetTop()
    {
        if (PlayerPrefs.HasKey(TAG_TOP))
        {
            return PlayerPrefs.GetInt(TAG_TOP);
        }
        else
        {
            return 112110;
        }
    }

    public static void SaveTop(int newHightScore)
    {
        PlayerPrefs.SetInt(TAG_TOP, newHightScore);
    }



    public static int GetHightSecond()
    {
        if (PlayerPrefs.HasKey(TAG_HIGHTSECOND))
        {
            return PlayerPrefs.GetInt(TAG_HIGHTSECOND);
        }
        else
        {
            return 0;
        }
    }

    public static void SaveHightSecond(int newHightScore)
    {
        PlayerPrefs.SetInt(TAG_HIGHTSECOND, newHightScore);
    }



    public static string GetMac()
    {
        if (PlayerPrefs.HasKey(TAG_MAC))
        {
            return PlayerPrefs.GetString(TAG_MAC);
        }
        else
        {
            return "";
        }
    }

    public static void SaveMac(string newHightScore)
    {
        PlayerPrefs.SetString(TAG_MAC, newHightScore);
    }

    //----------------------------------------------------

    public static string GetName()
    {
        if (PlayerPrefs.HasKey(TAG_NAME))
        {
            return PlayerPrefs.GetString(TAG_NAME);
        }
        else
        {
            return "";
        }
    }

    public static void SaveName(string newHightScore)
    {
        PlayerPrefs.SetString(TAG_NAME, newHightScore);
    }


    public static int GetHightScore()
    {
        if (PlayerPrefs.HasKey(TAG_HIGHTSCORE))
        {
            return PlayerPrefs.GetInt(TAG_HIGHTSCORE);
        }
        else
        {
            return 0;
        }
    }

    public static void SaveHightScore(int newHightScore)
    {
        PlayerPrefs.SetInt(TAG_HIGHTSCORE, newHightScore);
    }


 

}