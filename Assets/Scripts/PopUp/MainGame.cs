using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainGame : MonoBehaviour {

    public tk2dUIItem btnContinute;
    public tk2dUIItem btnDiemCao;
	public tk2dUIItem btnExit;
	public tk2dUIItem btnVolums;

	void btnVolums_OnClick()
	{
		try
		{
			if(GameController.instance.checkVoulumOpen)
			{
				btnVolums.transform.GetComponent<tk2dSprite>().SetSprite("vollock");
				SoundController.Instance.Stop();
				SoundController.Instance.PauseBGMusic();		
				GameController.instance.checkVoulumOpen=false;
			}else
			{
				btnVolums.transform.GetComponent<tk2dSprite>().SetSprite("volopen");
				SoundController.Instance.rePlayBGMusic();
				GameController.instance.checkVoulumOpen=true;
			}
		}
		catch (System.Exception)
		{

			throw;
		}

	}

	void btnExit_OnClick()
	{
		try
		{
			Application.Quit();
		}
		catch (System.Exception)
		{

			throw;
		}

	}


    void btnContinute_OnClick()
    {
		try
		{
        PopupController.instance.ShowSHA();
        SoundController.Instance.Stop();
        SoundController.Instance.PlayChungTa();
        PopupController.instance.HideMainGame();
        StartCoroutine(WaitTimeSHA(4f));
		}
		catch (System.Exception)
		{

			throw;
		}
    
    }

    IEnumerator WaitTimeSHA(float time)
    {
        //do something...............
        yield return new WaitForSeconds(time);

        PopupController.instance.HideSHA();
        GameController.instance.suget();
        GameController.instance.currentState = GameController.State.Question;


    }

    void btnDiemCao_OnClick()
    {
		try
		{
           PopupController.instance.ShowPopupMaxScore();
           PopupController.instance.HideMainGame();
	   }
	  catch (System.Exception)
	   {

		 throw;
	   }
      
    }

	// Use this for initialization
	void Start () {
        btnDiemCao.OnClick += btnDiemCao_OnClick;
        btnContinute.OnClick += btnContinute_OnClick;
		btnExit.OnClick += btnExit_OnClick;
		btnVolums.OnClick += btnVolums_OnClick;
      
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
