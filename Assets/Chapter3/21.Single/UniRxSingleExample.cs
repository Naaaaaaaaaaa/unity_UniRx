/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class UniRxSingleExample : MonoBehaviour
    {
        void Start()
        {
            var subject = new Subject<int>();

            subject.Where(number => number % 2 == 0)
                   .Single()
                   .Subscribe(number => Debug.Log(number));

            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);

            subject.OnCompleted();
        }
    }
}