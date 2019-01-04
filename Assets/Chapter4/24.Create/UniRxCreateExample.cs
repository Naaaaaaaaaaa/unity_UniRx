/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System;

namespace UniRxLesson
{
    public class UniRxCreateExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Create<int>(observer =>
            {
                observer.OnNext(1);
                observer.OnNext(2);

                Observable.Timer(TimeSpan.FromSeconds(1.0f))
                          .Subscribe(_ => observer.OnCompleted());

                return Disposable.Create(() => Debug.Log("观察者已销毁"));
            }).Subscribe(number => Debug.LogFormat("number is:{0}", number));
        }
    }
}