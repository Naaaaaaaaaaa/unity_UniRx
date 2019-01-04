/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;
using UniRx.Triggers;
using System.Collections.Generic;

namespace UniRxLesson
{
    public class UniRxCatchExample : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Observable.Throw<string>(new Exception("error"))
                      .Catch<string, Exception>(e =>
                      {
                          Debug.LogFormat("catched excpetion:{0}", e.Message);
                          return Observable.Timer(TimeSpan.FromSeconds(1.0f))
                                           .Select(_ => "timer called");
                      })
                      .Subscribe(result => Debug.Log(result));
        }
    }
}