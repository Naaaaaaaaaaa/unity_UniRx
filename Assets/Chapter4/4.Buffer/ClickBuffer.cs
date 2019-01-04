/**====================================
 *Copyright(C) 2018 by Wipace 
 *All rights reserved. 
 *FileName:     .cs 
 *Author:       CGzhao 
 *Version:      1.0 
 *UnityVersion：2018.2.3 
 *Date:         2018-11-27 
 *Email:		1341674064@qq.com
 *Description:    
 *History: 
======================================**/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;

public class ClickBuffer : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		//多次点击检测
//		var clickEvent = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0));
//		var obser = clickEvent.Buffer(TimeSpan.FromSeconds(1.0f));
//		obser.Where(clicks => clicks.Count != 0)
//			.Subscribe(clicks => Debug.Log("clicks count: " + clicks.Count));

		Observable.EveryUpdate()
			.Where(_ => Input.GetMouseButtonDown(0))
			.Buffer(TimeSpan.FromMilliseconds(250))
			.Where(clicks => clicks.Count != 0)
			.Subscribe(clicks => Debug.Log("clicks count: " + clicks.Count));
	}
}
