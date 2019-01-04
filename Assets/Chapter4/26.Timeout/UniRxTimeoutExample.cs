/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System;

namespace UniRxLesson
{
    public class UniRxTimeoutExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .Timeout(TimeSpan.FromSeconds(3.0f))
                      .Subscribe(_ =>
                      {
                          Debug.Log("mouse clicked");
                      });


            ObservableWWW.Get("http://sikiedu.com")
                         .Timeout(TimeSpan.FromSeconds(0.1f))
                         .Subscribe(_ => { }, e =>
                         {
                             Debug.LogErrorFormat("发生了异常:{0}", e.Message);
                         });
        }
    }
}