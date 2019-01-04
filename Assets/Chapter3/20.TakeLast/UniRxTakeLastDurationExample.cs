/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class UniRxTakeLastDurationExample : MonoBehaviour
    {
        void Start()
        {
            var subject = new Subject<float>();

            subject
                .TakeLast(TimeSpan.FromSeconds(2.0))
                .Subscribe(clickedTime => Debug.Log(clickedTime));


            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .Subscribe(_ => subject.OnNext(Time.time));

            Observable.Timer(TimeSpan.FromSeconds(5.0f))
                      .Subscribe(_ => subject.OnCompleted());

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}