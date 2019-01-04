/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class UniRxAggregateExample : MonoBehaviour
    {
        private void Start()
        {
            var subject = new Subject<int>();

            subject.Aggregate((max, nextValue) => max > nextValue ? max : nextValue)
                   .Subscribe(result => Debug.Log(result));

            subject.OnNext(1);
            subject.OnNext(3);
            subject.OnNext(100);
            subject.OnNext(50);
            subject.OnCompleted();
        }
    }
}