using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebViewButtonManager : MonoBehaviour{


　/// <summary>
　/// WebView起動ボタン押下時
　/// </summary>
　public void LegalButton_OnClick()
　{

#if UNITY_EDITOR_WIN
　　　// MacでないとUnity上でデバックできないため
　　　Application.OpenURL("https://www.google.co.jp/");

#else
　　　// オブジェクトを複製し、有効にする
　　　GameObject WVO = Instantiate(GameObject.Find("Canvas").transform.Find("WebViewButton/WebViewObjectOrigin").gameObject);
　　　WVO.SetActive(true);
#endif
　}
}
