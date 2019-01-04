using UnityEngine;
using System.Collections;

public class PopupController : MonoBehaviour {


    public PopUpGameOver gameOver;
    public PopUpKhanGia khangia;
    public PopUpNguoiThan nguoithan;
    public PopUpWin iwin;
    public PopUpSHA sha;
    public MainGame mainGame;
    public PopUpStopGame stopGame;
    public MaxScore maxScore;

	public TuVan tuvan;

    public float showPositionYMainGame;


    public float showPositionY;
    public float hidePostionY;

    public float showPositionYKhanGia;
 

    public float moveSpeed;

    public float showPositionYNguoiThan;
    public float showPositionYIwin;


	public void HidePopupTuVan()
	{
		StartCoroutine(ieMoveUp(tuvan.gameObject));

	}

	public void ShowPopupTuVan()
	{
		tuvan.setData ();
		tuvan.transform.position = new Vector3(tuvan.transform.position.x, showPositionYMainGame, 10f);
	}


    public void HidePopupMaxScore()
    {
        StartCoroutine(ieMoveUp(maxScore.gameObject));

    }

    public void ShowPopupMaxScore()
    {
        maxScore.setData();
        maxScore.transform.position = new Vector3(maxScore.transform.position.x, showPositionYMainGame, 10f);
    }


    public void HidePopupStop()
    {
        StartCoroutine(ieMoveUpKG(stopGame.gameObject));

    }

    public void ShowPopupStop(int level)
    {
        stopGame.setlevel(level);
        stopGame.transform.position = new Vector3(stopGame.transform.position.x, showPositionY, 10f);
    }



    #region Singleton
    private static PopupController _instance;

    public static PopupController instance
    {
        get
        {
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<PopupController>();
            return _instance;
        }
    }
    #endregion


    IEnumerator ieMoveDown(GameObject popup)
    {
        while (popup.transform.position.y > showPositionY)
        {
            popup.transform.position += Vector3.down
                * (moveSpeed+300)
                * Time.deltaTime;
            yield return 0;
        }
        popup.transform.position = new Vector3(popup.gameObject.transform.position.x, showPositionY, popup.gameObject.transform.position.z);

    }

    IEnumerator ieMoveUp(GameObject popup)
    {
        while (popup.transform.position.y < hidePostionY)
        {
            popup.transform.position += Vector3.up
                * (moveSpeed + 300)
                * Time.deltaTime;
            yield return 0;
        }
        popup.transform.position = new Vector3(popup.gameObject.transform.position.x, hidePostionY, popup.gameObject.transform.position.z);
       
    }

    IEnumerator ieMoveLeft(GameObject popup)
    {
        while (popup.transform.position.x > 0f)
        {
            popup.transform.position += Vector3.left
                * (moveSpeed+200)
                * Time.deltaTime;
            yield return 0;
        }
		popup.transform.position = new Vector3(0f, popup.gameObject.transform.position.y, popup.gameObject.transform.position.z);
    }

    IEnumerator ieMoveRight(GameObject popup)
    {
        while (popup.transform.position.x < 1500f)
        {
            popup.transform.position += Vector3.right
                * (moveSpeed + 200)
                * Time.deltaTime;
            yield return 0;
        }
		popup.transform.position = new Vector3(1500f, popup.gameObject.transform.position.y, popup.gameObject.transform.position.z);
    }
    public void ShowSHA()
    {
        StartCoroutine(ieMoveLeft(sha.gameObject));
    }


    public void HideSHA()
    {
        StartCoroutine(ieMoveRight(sha.gameObject));
    }


  

    IEnumerator ieMoveUpKG(GameObject popup)
    {
        while (popup.transform.position.y < hidePostionY)
        {
            popup.transform.position += Vector3.up
                * moveSpeed
                * Time.deltaTime;
            yield return 0;
        }
		popup.transform.position = new Vector3(popup.gameObject.transform.position.x, hidePostionY, popup.gameObject.transform.position.z);
    }

    IEnumerator ieMoveDownMain(GameObject popup)
    {
        while (popup.transform.position.y >= showPositionYMainGame)
        {
            popup.transform.position += Vector3.down
                * moveSpeed
                * Time.deltaTime;
            yield return 0;
        }
		popup.transform.position = new Vector3(popup.gameObject.transform.position.x, showPositionYMainGame, popup.gameObject.transform.position.z);
    }

    IEnumerator ieMoveUpMain(GameObject popup)
    {
        while (popup.transform.position.y < hidePostionY)
        {
            popup.transform.position += Vector3.up
                * moveSpeed
                * Time.deltaTime;
            yield return 0;
        }
		popup.transform.position = new Vector3(popup.gameObject.transform.position.x, hidePostionY, popup.gameObject.transform.position.z);
    }

    public void ShowMainGame()
    {
        StartCoroutine(ieMoveDownMain(mainGame.gameObject));
    }

    public void HideMainGame()
    {
        StartCoroutine(ieMoveUpMain(mainGame.gameObject));
    }

    public void ShowPopUpWin()
    {
        iwin.transform.position = new Vector3(iwin.transform.position.x, showPositionYIwin, 10f);
    }

    public void HidePopUpWin()
    {
        iwin.transform.position = new Vector3(iwin.transform.position.x, hidePostionY, 10f);
    }


    public void ShowPopUpNguoiThan()
    {
        nguoithan.transform.position = new Vector3(nguoithan.transform.position.x, showPositionYNguoiThan, 10f);
    }

    public void HidePopupNguoiThan()
    {
        StartCoroutine(ieMoveUpKG(nguoithan.gameObject));

    }



    public void HidePopupKhanGia()
    {
        StartCoroutine(ieMoveUpKG(khangia.gameObject));

    }

    public void ShowPopupKhanGia()
    {
        khangia.setPhanTram();
        khangia.transform.position = new Vector3(khangia.transform.position.x, showPositionYKhanGia, 10f);
    }



    public void HidePopupGameOver()
    {
        StartCoroutine(ieMoveUp(gameOver.gameObject));
 
    }

    public void ShowPopupGameOver(int level,int maxlevel)
    {
        gameOver.setlevel(level, maxlevel);
        StartCoroutine(ieMoveDown(gameOver.gameObject));
        HidePopupKhanGia();
        HidePopupNguoiThan();
		HidePopupTuVan();
        nguoithan.resetNguoiThan();
       
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
