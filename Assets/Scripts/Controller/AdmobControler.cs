using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdmobControler : MonoBehaviour {


	#region Singleton
	private static AdmobControler _instance;

	public static AdmobControler Instance
	{
		get
		{
			if (_instance == null)
				_instance = GameObject.FindObjectOfType<AdmobControler>();
			return _instance;
		}
	}
	#endregion

	private BannerView bannerView;
	AdRequest request;

	InterstitialAd interstitial;

	public void RequestInterstitial()
	{
		interstitial = new InterstitialAd(Config.adsInIDGameOver);
		AdRequest request = new AdRequest.Builder().Build();
		// Load the interstitial with the request.
		interstitial.LoadAd(request);
	}

	public void ShowAdsInterstitial()
	{
		if (interstitial.IsLoaded())
		{
			interstitial.Show();
		}
	}

	// Use this for initialization
	void Start () {
		MobileAds.Initialize(Config.appId);

		this.RequestBanner();
	}

	public void RequestBanner()
	{
		

		// Create a 320x50 banner at the top of the screen.
		bannerView = new BannerView(Config.adsInIDBanner, AdSize.Banner, AdPosition.Top);
		// Create an empty ad request.
		 request = new AdRequest.Builder().Build();

		// Load the banner with the request.
	
		}


	public void ShowAdsBanner()
	{
		bannerView.LoadAd(request);
		bannerView.Show();
	}

	public void HideAdsBanner()
	{
		bannerView.Hide();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
