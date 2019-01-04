using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PopUpStopGame : MonoBehaviour {

    public tk2dUIItem btnContinute;
    public tk2dUIItem btnStopGame;
    public tk2dTextMesh txtLevel;

    


 

    void callResetDapAn()
    {
        DapAnController.instance.resetDapAN();
     
    }

    public void setlevel(int level)
    {
        txtLevel.text = "Vượt qua: Câu " + level;
		AdmobControler.Instance.ShowAdsBanner();
    }


    void btnContinute_OnClick()
    {
        try
        {
           //HideOp
            GameController.instance.currentState = GameController.State.Question;
            PopupController.instance.HidePopupStop();
			AdmobControler.Instance.HideAdsBanner();
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    void btnStopGame_onClick()
    {
        try
        {
            SoundController.Instance.PlayTamBiet();
            GameController.instance.doSave();
            callResetDapAn();
            PopupController.instance.HidePopupGameOver();
            PopupController.instance.HidePopupKhanGia();
            PopupController.instance.HidePopupNguoiThan();
            PopupController.instance.HidePopUpWin();
            PopupController.instance.HidePopupStop();
            PopupController.instance.ShowMainGame();
            TroGiupControlller.instance.resetHelp();
            GameController.instance.level = 1;
			AdmobControler.Instance.HideAdsBanner();
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
    }



    // Use this for initialization
    void Start()
    {
        btnContinute.OnClick += btnContinute_OnClick;
        btnStopGame.OnClick += btnStopGame_onClick;
		//AdmobControler.RequestBanner();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
