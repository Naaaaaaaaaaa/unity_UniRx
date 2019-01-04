/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System;

namespace UniRxLesson
{
    public class UniRxObserveOnMainThreadExample : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(Time.time);

            Observable.Start(() =>
            {

                Thread.Sleep(TimeSpan.FromSeconds(1.0f));
                return "hello thread";
            }).ObserveOnMainThread()
                      .Subscribe(threadResult =>
                      {
                          Debug.LogFormat("{0} {1}", threadResult, Time.time);
                      });
        }
    }
}