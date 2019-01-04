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
    public class UniRxFinallyExample : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            var subject = new Subject<int>();
            var result = subject.Finally(() => Debug.Log("Finally action run"));

            result.Subscribe(number => Debug.LogFormat("OnNext({0});", number), () => Debug.Log("OnCompleted"));

            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            //subject.OnError(new Exception());
            subject.OnCompleted();

        }
    }
}