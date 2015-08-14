using NCMB; //mobile backendのSDKを読み込む
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;

public class Bg_ghost : MonoBehaviour {
	public static NCMBObject posObj;
	public static bool readyGhost = false;
	// Use this for initialization
	void Start () {
		NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject> ("Score");
		query.OrderByDescending ("score");
		query.Limit = 1;
		query.FindAsync ((List<NCMBObject> objList ,NCMBException e) => {
			
			if (e != null) {
				//検索失敗時の処理
			} else {
				//検索成功時の処理
				
				// 取得したレコードをscoreクラスとして保存
				foreach (NCMBObject obj in objList) {
					posObj = obj;
					//--- 下記の２文は動かしてみて、問題なければ削除
					//string s = System.Convert.ToString( ((ArrayList)((ArrayList)obj["Log"])[0])[1]);
					//IList familyList = (IList)Json.Deserialize(System.Convert.ToString(obj));
					
				}
				readyGhost = true;
			}
		});


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
