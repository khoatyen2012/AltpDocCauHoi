using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour
{
    public AudioSource audioSourceBGMusicPrefab;
    private AudioSource audioSourceBGMusicCreated;

    public AudioClip[] arrAudioClip;

    bool ok = true;

    #region Singleton
    private static SoundController _instance;

    public static SoundController Instance
    {
        get
        {
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<SoundController>();
            return _instance;
        }
    }
    #endregion

    void Awake()
    {
        PlayBGMusic();

    }

    // Update is called once per frame
    void Update()
    {
		if ((!CheckISPlay()) && (ok == false)&&(GameController.instance.checkVoulumOpen))
        {

            audioSourceBGMusicCreated.Play();
            ok = true;
        }
    }


    void PlayBGMusic()
    {
        audioSourceBGMusicCreated =
            GameObject.Instantiate
            (
                audioSourceBGMusicPrefab
            ) as AudioSource;
        audioSourceBGMusicCreated.loop = true;
        audioSourceBGMusicCreated.Play();   


    }

	public void rePlayBGMusic()
	{
		audioSourceBGMusicCreated.Play();
	}
	public void StopBGMusic()
	{
		audioSourceBGMusicCreated.Stop();
	}

	public void PauseBGMusic()
	{
		audioSourceBGMusicCreated.Pause();
	}

    public void PlayBatDau()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [0]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHoi1()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [1]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHoi2()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [2]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }


    public void PlayHoi3()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [3]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }


    public void PlayHoi4()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [4]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHoi5()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [5]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHoi6()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [6]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHoi7()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [7]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHoi8()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [8]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHoi9()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [9]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHoi10()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [10]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHoi11()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [11]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHoi12()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [12]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHoi13()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [13]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHoi14()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [14]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHoi15()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [15]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayChungTa()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [16]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayChonA()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [17]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayChonB()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [18]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayChonC()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [19]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayChonD()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [20]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayGoiNguoiThan()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [21]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayHetGio()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [22]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayKhanGia()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [23]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlaySaiA()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [24]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlaySaiB()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [25]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }
    public void PlaySaiC()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [26]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlaySaiD()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [27]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }
    public void PlayNamMuoi()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [28]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }


    public void PlayDuaRa1()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [29]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayDuaRa2()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [30]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }


    public void PlayVuotQua14()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [31]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }



    public void PlayVuotQua15()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [32]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }


    public void PlayCamXuc()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [33]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayQuanTrong()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [34]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayTamBiet()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [35]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayDungA()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [36]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayDungB()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [37]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayDungC()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [38]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayDungD()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [39]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayAB()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [40]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayAC()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [41]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayAD()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [42]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayBC()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [43]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayBD()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [44]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

    public void PlayCD()
    {
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [45]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
    }

	public void PlayHetMoc5()
	{
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [46]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
	}

	public void PlayHetMoc10()
	{
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [47]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
	}

	public void PlayHoiToTuVan()
	{
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [48]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
	}
	public void PlayPing()
	{
		if (GameController.instance.checkVoulumOpen) {
			tk2dUIAudioManager.Instance.Play (arrAudioClip [49]);
			audioSourceBGMusicCreated.Pause ();
			ok = false;
		}
	}

    public void Stop()
    {
        tk2dUIAudioManager.Instance.curentStop();
    }

    public bool CheckISPlay()
    {
        return tk2dUIAudioManager.Instance.CheckPlay();
    }
}
