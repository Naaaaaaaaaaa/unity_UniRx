/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System.Collections.Generic;

namespace UniRxLesson
{
    public class UniRxCastExample : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            var subject = new Subject<object>();

            subject.Cast<object, string>()
            .Subscribe(value => Debug.Log(value), e =>
            {
                Debug.Log("has exception");
                Debug.LogException(e);
            });

            subject.OnNext("123123");
            subject.OnNext("123123");
            subject.OnNext(123);
            subject.OnCompleted();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}