using UnityEngine;
using System.Collections;


public class PopUpGameOver : MonoBehaviour {

    public tk2dUIItem btnContinute;

    public tk2dTextMesh txtLevel;
    public tk2dTextMesh txtMaxLevel;

	public tk2dUIItem btnShare;
	public tk2dUIItem btnRate;

	public void btnShare_OnClick()
	{
		ShareRate.Share ();
	}

	public void btnRate_OnClick()
	{
		ShareRate.Rate ();
	}

  

    void callResetDapAn()
    {
         DapAnController.instance.resetDapAN();
         
    }

    public void setlevel(int level, int maxlevel)
    {
        txtLevel.text = "Vượt qua: Câu " + level;
        txtMaxLevel.text = "Thời gian: " + maxlevel+" giây.";
		AdmobControler.Instance.RequestInterstitial();
    }


    void btnContinute_OnClick()
    {
        try
        {
            SoundController.Instance.PlayTamBiet();
            callResetDapAn();
            PopupController.instance.HidePopupGameOver();
            PopupController.instance.HidePopupKhanGia();
            PopupController.instance.HidePopupNguoiThan();
            PopupController.instance.HidePopUpWin();
            PopupController.instance.ShowMainGame();
            TroGiupControlller.instance.resetHelp();
            GameController.instance.level = 1;
           
            //callResetDapAn();
            //TroGiupControlller.instance.resetHelp();
            //PopupController.instance.HidePopupGameOver();
            //GameController.instance.setDefault();
            //GameController.instance.suget();
        }
        catch (System.Exception)
        {

            throw;
        }
		AdmobControler.Instance.ShowAdsInterstitial();
    }

 

	// Use this for initialization
	void Start () {
        btnContinute.OnClick += btnContinute_OnClick;
		btnShare.OnClick += btnShare_OnClick;
		btnRate.OnClick += btnRate_OnClick;
      
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
