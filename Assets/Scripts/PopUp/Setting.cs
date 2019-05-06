using UnityEngine;
using System.Collections;

public class Setting : MonoBehaviour {

	public tk2dUIItem btnOnOff;
	public tk2dUIItem btnBack;

	public void setData()
	{
		if (GameController.instance.checkRedQuestionOpen==0) {
			btnOnOff.gameObject.GetComponent<tk2dSprite> ().SetSprite ("turnon");

		} else {
			btnOnOff.gameObject.GetComponent<tk2dSprite> ().SetSprite ("tunroff");

		}
	}

	public void btnOnOff_OnClick()
	{
		if (GameController.instance.checkRedQuestionOpen==0) {
			GameController.instance.checkRedQuestionOpen = 10;
			DataController.SaveRedQuestion (10);
			btnOnOff.gameObject.GetComponent<tk2dSprite> ().SetSprite ("tunroff");
		} else {
			GameController.instance.checkRedQuestionOpen = 0;
			DataController.SaveRedQuestion (0);
			btnOnOff.gameObject.GetComponent<tk2dSprite> ().SetSprite ("turnon");
		}

	}

	public void btnBack_OnClick()
	{
		PopupController.instance.ShowMainGameTinh ();
		PopupController.instance.HidePopupSetting ();
	}

	// Use this for initialization
	void Start () {
		btnOnOff.OnClick += btnOnOff_OnClick;
		btnBack.OnClick += btnBack_OnClick;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
