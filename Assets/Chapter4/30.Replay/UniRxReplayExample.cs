/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using System;
using System.Collections;
using UniRx;
using UnityEngine;

namespace UniRxLesson
{
    public class UniRxReplayExample : MonoBehaviour
    {
        void Start()
        {
            var replayObservable = Observable.Interval(TimeSpan.FromSeconds(1.0f))
                                             .Do(l => Debug.LogFormat("Observable:{0}", l))
                                             .Replay();

            replayObservable.Subscribe(l => Debug.LogFormat("Subscription #1:{0}", l));
            replayObservable.Connect();

            Observable.Timer(TimeSpan.FromSeconds(5.0f))
                      .Subscribe(_ =>
                      {
                          replayObservable.Subscribe(l => Debug.LogFormat("Subscription #2:{0}", l));
                      });
        }
    }
}