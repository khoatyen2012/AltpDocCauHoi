using UnityEngine;
using System.Collections;

public class Config  {

#if UNITY_IPHONE
	public static string appId = "ca-app-pub-2127327600096597~5144496862";
	public static string adsInIDGameOver = "ca-app-pub-2127327600096597/2550957266";
	public static string adsInIDBanner = "ca-app-pub-2127327600096597/8097963269";

#endif

#if UNITY_ANDROID

	public static string appId = "ca-app-pub-2127327600096597~2657993406";
	public static string adsInIDGameOver = "ca-app-pub-2127327600096597/8457114998";
	public static string adsInIDBanner = "ca-app-pub-2127327600096597/3452200322";
  



#endif

}
