﻿/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;
using UniRx.Triggers;

namespace UniRxLesson
{
    public class UniRxDelayExample : MonoBehaviour
    {
        void Start()
        {
            //Observable.EveryUpdate()
            //.Where(_ => Input.GetMouseButtonDown(0))
            //.Delay(TimeSpan.FromSeconds(1.0))
            //.Subscribe(_ => Debug.Log("after 1 seconds"));

            Observable.Timer(TimeSpan.FromSeconds(1.0f))
                      .Select(_ =>
                      {
                          Debug.Log("1 seconds");
                          return _;
                      })
                      .Delay(TimeSpan.FromSeconds(1.0f))
                      .Select(_ =>
                      {
                          Debug.Log("2 seconds");
                          return _;
                      })
                      .Delay(TimeSpan.FromSeconds(1.0f))
                      .Subscribe(_ => Debug.Log("3 seconds"));


            Observable.ReturnUnit()
                      .Delay(TimeSpan.FromSeconds(1.0f))
                      .Subscribe();
        }
    }
}