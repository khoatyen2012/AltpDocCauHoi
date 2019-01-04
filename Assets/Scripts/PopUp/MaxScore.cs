using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MaxScore : MonoBehaviour {


    public tk2dUIItem btnXepHang;
    public tk2dUIItem btnHome;
	//public tk2dUIItem btnHoiNgu;
	//public tk2dUIItem btnLichVanNien;
    public tk2dTextMesh txtCau;



    public void setData()
    {
		AdmobControler.Instance.ShowAdsBanner();
        string cau="Câu "+DataController.GetHightScore();
        txtCau.text = cau;

    }


    public void btnXepHang_OnClick()
    {
		try
		{
			AdmobControler.Instance.HideAdsBanner();
        SceneManager.LoadScene("Rank");
		}
		catch (System.Exception)
		{

			throw;
		}
    }

    public void btnHome_OnClick()
    {
		try
		{
        PopupController.instance.ShowMainGame();
        PopupController.instance.HidePopupMaxScore();
			AdmobControler.Instance.HideAdsBanner();
	}
	catch (System.Exception)
	{

		throw;
	}
    }

	public void btnHoiNgu_OnClick()
	{
		try
		{
		ShareRate.RateHoiNgu ();
		}
		catch (System.Exception)
		{

			throw;
		}
	}
	public void btnLichVanNien_OnClick()
	{
			try
			{
		ShareRate.RateLVN ();
		}
		catch (System.Exception)
		{

			throw;
		}
	}

	// Use this for initialization
	void Start () {
        btnXepHang.OnClick += btnXepHang_OnClick;
        btnHome.OnClick += btnHome_OnClick;
		//btnHoiNgu.OnClick += btnHoiNgu_OnClick;
		//btnLichVanNien.OnClick += btnLichVanNien_OnClick;
     
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
