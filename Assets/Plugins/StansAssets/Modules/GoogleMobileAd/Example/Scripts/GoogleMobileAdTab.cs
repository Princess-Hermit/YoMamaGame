using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class GoogleMobileAdTab : FeatureTab {
	
	//replace with your ids
	private const string MY_BANNERS_AD_UNIT_ID		 = "ca-app-pub-6101605888755494/1824764765";
	private const string MY_INTERSTISIALS_AD_UNIT_ID =  "ca-app-pub-6101605888755494/3301497967";
	private const string MY_REWARDED_VIDEO_AD_UNIT_ID =  "ca-app-pub-6101605888755494/5378283960";
	
	private GoogleMobileAdBanner Banner;
	private GoogleMobileAdBanner SmartBanner;
	
	private bool IsInterstisialsAdReady = false;
	private bool IsVideoAdReady = false;
	
	[SerializeField]
	private Button ShowInterstitialButton;
	[SerializeField]
	private Button ShowVideoButton;
	
	public Toggle CustomPosTgl;
	public Toggle UpperLeftTgl;
	public Toggle UpperCenterTgl;
	public Toggle UpperRightTgl;
	public Toggle BottomLeftTgl;
	public Toggle BottomCenterTgl;
	public Toggle BottomRightTgl;
	
	public Button BannerHideBtn;
	public Button BannerCreateBtn;
	public Button BannerRefreshBtn;
	public Button BannerChangePosRandomBtn;
	public Button BannerDestroyBtn;
	
	public Toggle SmartBotPosTgl;
	public Toggle SmartTopPosTgl;
	
	public Button SmartHide;
	public Button SmartCreate;
	public Button SmartRefresh;
	public Button SmartDestroy;
	
	private Nullable<TextAnchor> BannerPosition = null;
	private TextAnchor SmartBannerPosition = TextAnchor.UpperCenter;
	
	//--------------------------------------
	// INITIALIZE
	//--------------------------------------	

	void Start() {
		///Toggle switches logic implementation
		CustomPosTgl.onValueChanged.AddListener ((b) => { if (b) BannerPosition = null;});
		UpperLeftTgl.onValueChanged.AddListener ((b) => { if (b) BannerPosition = TextAnchor.UpperLeft;});
		UpperCenterTgl.onValueChanged.AddListener ((b) => { if (b) BannerPosition = TextAnchor.UpperCenter;});
		UpperRightTgl.onValueChanged.AddListener ((b) => { if (b) BannerPosition = TextAnchor.UpperRight;});

		BottomLeftTgl.onValueChanged.AddListener ((b) => { if (b) BannerPosition = TextAnchor.LowerLeft;});
		BottomCenterTgl.onValueChanged.AddListener ((b) => { if (b) BannerPosition = TextAnchor.LowerCenter;});
		BottomRightTgl.onValueChanged.AddListener ((b) => { if (b) BannerPosition = TextAnchor.LowerRight;});
		
		SmartTopPosTgl.onValueChanged.AddListener ((b) => { if (b) SmartBannerPosition = TextAnchor.UpperCenter;});
		SmartBotPosTgl.onValueChanged.AddListener ((b) => { if (b) SmartBannerPosition = TextAnchor.LowerCenter;});
	}
			
	public void Init() {
		GoogleMobileAd.Init();
		//Optional, add data for better ad targeting
		GoogleMobileAd.SetGender(GoogleGender.Male);
		GoogleMobileAd.AddKeyword("game");
		GoogleMobileAd.SetBirthday(1989, AndroidMonth.MARCH, 18);
		GoogleMobileAd.TagForChildDirectedTreatment(false);
		
		//Causes a device to receive test ads. The deviceId can be obtained by viewing the logcat output after creating a new ad
		//AndroidAdMobController.instance.AddTestDevice("6B9FA8031AEFDC4758B7D8987F77A5A6");
		
		GoogleMobileAd.OnInterstitialLoaded += OnInterstisialsLoaded; 
		GoogleMobileAd.OnInterstitialOpened += OnInterstisialsOpen;
		
		AndroidAdMobController.Instance.OnRewardedVideoLoaded += HandleOnRewardedVideoLoaded;
		AndroidAdMobController.Instance.OnRewardedVideoAdClosed += HandleOnRewardedVideoAdClosed;
		
		//listening for InApp Event
		//You will only receive in-app purchase (IAP) ads if you specifically configure an IAP ad campaign in the AdMob front end.
		GoogleMobileAd.OnAdInAppRequest += OnInAppRequest;
	}

	public void StartInterstitialAd() {
		GoogleMobileAd.StartInterstitialAd ();
	}
	
	public void LoadInterstitialAd() {
		GoogleMobileAd.LoadInterstitialAd ();
	}
	
	public void ShowInterstitialAd() {
		GoogleMobileAd.ShowInterstitialAd ();
	}

	public void StartRewardedVideoAd () {
		AndroidAdMobController.Instance.StartRewardedVideo();
	}

	public void LoadRewardedVideoAd () {
		AndroidAdMobController.Instance.LoadRewardedVideo();
	}
	
	public void ShowRewardedVideoAd () {
		AndroidAdMobController.Instance.ShowRewardedVideo();
	}
	
	public void BannerHide() {
		Banner.Hide();
	}
	
	public void BannerCreate() {
		Banner = BannerPosition != null ? GoogleMobileAd.CreateAdBanner(BannerPosition.Value, GADBannerSize.BANNER)
			: GoogleMobileAd.CreateAdBanner(300, 100, GADBannerSize.BANNER);
	}
	
	public void BannerRefresh() {
		Banner.Refresh();
	}
	
	public void BannerDestroy() {
		GoogleMobileAd.DestroyBanner(Banner.id);
		Banner = null;
	}
	
	public void SmartBannerHide() {
		SmartBanner.Hide();
	}	
	
	public void SmartBannerCreate() {
		SmartBanner = GoogleMobileAd.CreateAdBanner(SmartBannerPosition, GADBannerSize.SMART_BANNER);
	}
	
	public void SmartBannerRefresh() {
		SmartBanner.Refresh();
	}
	
	public void SmartBannerDestroy() {
		GoogleMobileAd.DestroyBanner(SmartBanner.id);
		SmartBanner = null;
	}
		
	public void ChangePosRandom() {
		Banner.SetBannerPosition(UnityEngine.Random.Range(0, Screen.width), UnityEngine.Random.Range(0, Screen.height));
	}	
	
	//--------------------------------------
	//  PUBLIC METHODS
	//--------------------------------------	
	
	void FixedUpdate() {
		if(IsInterstisialsAdReady) {
			ShowInterstitialButton.interactable = true;
		} else {
			ShowInterstitialButton.interactable = false;
		}

		if(IsVideoAdReady) {
			ShowVideoButton.interactable = true;
		} else {
			ShowVideoButton.interactable = false;
		}

		if (Banner != null) {			
			BannerDestroyBtn.interactable = true;
			
			if (Banner.IsLoaded) {
				BannerRefreshBtn.interactable = true;
				BannerChangePosRandomBtn.interactable = true;
				if (Banner.IsOnScreen) {
					BannerHideBtn.interactable = true;
					BannerCreateBtn.interactable = false;
				} else {
					BannerHideBtn.interactable = false;
					BannerCreateBtn.interactable = true;
				}
			} else { 
				BannerRefreshBtn.interactable = false;
				BannerChangePosRandomBtn.interactable = false;
				BannerHideBtn.interactable = false;
				BannerCreateBtn.interactable = false;
			}
		} else {			
			BannerHideBtn.interactable = false;
			BannerCreateBtn.interactable = true;
			BannerRefreshBtn.interactable = false;
			BannerDestroyBtn.interactable = false;
			BannerChangePosRandomBtn.interactable = false;
		}
		
		if(SmartBanner != null) {			
			SmartDestroy.interactable = true;
			
			if(SmartBanner.IsLoaded) {
				SmartRefresh.interactable = true;
				if(SmartBanner.IsOnScreen) {
					SmartHide.interactable = true;
					SmartCreate.interactable = false;
				} else {
					SmartHide.interactable = false;
					SmartCreate.interactable = true;
				}
			} else { 
				SmartRefresh.interactable = false;
				SmartHide.interactable = false;
				SmartCreate.interactable = false;
			}			
		} else {
			SmartHide.interactable = false;
			SmartCreate.interactable = true;
			SmartRefresh.interactable = false;
			SmartDestroy.interactable = false;
		}		
	}
	
	//--------------------------------------
	//  GET/SET
	//--------------------------------------
	
	//--------------------------------------
	//  EVENTS
	//--------------------------------------
	
	private void OnInterstisialsLoaded() {
		IsInterstisialsAdReady = true;
	}
	
	private void OnInterstisialsOpen() {
		IsInterstisialsAdReady = false;
	}
		
	private void HandleOnRewardedVideoLoaded () {
		IsVideoAdReady = true;
	}
	
	private void HandleOnRewardedVideoAdClosed () {
		IsVideoAdReady = false;
	}
	
	private void OnInAppRequest(string productId) {		
		Debug.Log ("In App Request for product Id: " + productId + " received");
		//Then you should perfrom purchase  for this product id, using this or another game billing plugin
		//Once the purchase is complete, you should call RecordInAppResolution with one of the constants defined in GADInAppResolution:		
		GoogleMobileAd.RecordInAppResolution(GADInAppResolution.RESOLUTION_SUCCESS);		
	}	
	
	//--------------------------------------
	//  PRIVATE METHODS
	//--------------------------------------
	
	//--------------------------------------
	//  DESTROY
	//--------------------------------------	
}
