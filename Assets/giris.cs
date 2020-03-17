using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.IO;
using System;
using UnityEngine.AI;
using System.Text;
using UnityEngine;

public class giris : MonoBehaviour {

    public string txtFile = "eq-light-x";
    public string txtFile2 = "eq-light-z";
    public string txtFile3 = "eq-strong-x";
    public string txtFile4 = "eq-strong-z";
    string txtContents;
    string txtContents2;
    string txtContents3;
    string txtContents4;
    public GUIStyle GUIStyle;
    public GUIStyle GUIStyle2;
    float c;
    int f;
    string[] dizi;
    string[] dizi2;
    string[] dizi3;
    string[] dizi4;
    // Use this for initialization
    void Start () {

        TextAsset txtAssets = (TextAsset)Resources.Load(txtFile);
        txtContents = txtAssets.text;
        TextAsset txtAssets2 = (TextAsset)Resources.Load(txtFile2);
        txtContents2 = txtAssets2.text;
        TextAsset txtAssets3 = (TextAsset)Resources.Load(txtFile3);
        txtContents3 = txtAssets3.text;
        TextAsset txtAssets4 = (TextAsset)Resources.Load(txtFile4);
        txtContents4 = txtAssets4.text;
        dizi = txtContents.Split(',');
        dizi2 = txtContents2.Split(',');
        dizi3 = txtContents3.Split(',');
        dizi4 = txtContents4.Split(',');

        Time.timeScale = 0.0f;
        
        f = 0;

    }
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale==1.0f && f!=dizi.Length)
        {
            f++;
        }

       
        c = islemler.a;

    }
    private void OnGUI()
    {
        
        if (Time.time<c)
        {
            GUI.Label(new Rect(600, 125, Screen.width, Screen.height), Time.time+ "/"+c, GUIStyle);
        }
        else
        {
            GUI.Label(new Rect(600, 125, Screen.width, Screen.height),c+"/"+c, GUIStyle);
        }
        if (c == 149.03f && f<dizi.Length)
        {
            GUI.Label(new Rect(600, 170, Screen.width, Screen.height), "(0.00,0.00,0.00)", GUIStyle2);
            GUI.Label(new Rect(600, 215, Screen.width, Screen.height), dizi[f] + "/0.0/" + dizi2[f], GUIStyle);
        }
        else if(c==27.15f && f<dizi3.Length)
        {
            GUI.Label(new Rect(600, 215, Screen.width, Screen.height), dizi3[f] + "/0.0/" + dizi4[f], GUIStyle);
            GUI.Label(new Rect(600, 170, Screen.width, Screen.height), "(0.18,0.00,0.07)", GUIStyle2);
        }
        else
        {
            GUI.Label(new Rect(600, 215, Screen.width, Screen.height), "0", GUIStyle);
            GUI.Label(new Rect(600, 170, Screen.width, Screen.height), "0", GUIStyle2);
        }
        GUI.Label(new Rect(600, 150, Screen.width, Screen.height), "Ortalama İvme", GUIStyle2);
        GUI.Label(new Rect(600, 195, Screen.width, Screen.height), "Anlık İvme", GUIStyle2);

    }
    


}
