using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleWebviewObject : MonoBehaviour {


private WebViewObject webViewObject;
public const string url ="https://www.google.co.jp";

// Use this for initialization
void Start ()
{
　　// WebViewObjectの生成
　　this.webViewObject = new GameObject("WebViewObject").AddComponent<WebViewObject>();

　　//マージンを求める
　　int mX = Screen.width / 9;
　　int mY = Screen.height / 5;

　　// キャッシュ回避用タイムスタンプ
　　//string date = '?'+DateTime.Now.ToString();

　
　　// コールバック設定
　　this.webViewObject.Init((msg) =>
　　{
　　　　switch (msg)
　　　　{
　　　　　　case "シーン名":

　　　　　　　　// WebViewの停止

　　　　　　　　this.webViewObject.SetVisibility(false);
　　　　　　　　Destroy(this.webViewObject);

　　　　　　　　//シーンの遷移
　　　　　 　　   SceneManager.LoadScene(msg);
　　　　　　　　break;

　　　　　   case "close":
　　　　　　　　// WebViewの停止
　　　　　　　　this.webViewObject.SetVisibility(false);
　　　　　　　　Destroy(this.webViewObject);

Destroy(GameObject.Find("WebViewObjectOrigin(Clone)").gameObject);
　　　　　　　　break;
　　　　}
　　});

       // URLの設定
　　this.webViewObject.LoadURL(url);

       // マージン(余白)の設定
　　this.webViewObject.SetMargins(mX, mY, mX, mY);

　　// WebViewを有効にする
　　this.webViewObject.SetVisibility(true);
}
}