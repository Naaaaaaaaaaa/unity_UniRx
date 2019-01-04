/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System;

namespace UniRxLesson
{
    public class UniRxFromEventExample : MonoBehaviour
    {
        event Action mOnMouseDownEvent;

        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .Subscribe(_ => mOnMouseDownEvent.Invoke());

            Observable.FromEvent(mouseDownEvent => mOnMouseDownEvent += mouseDownEvent, mouseDownEvent => mOnMouseDownEvent -= mOnMouseDownEvent)
                      //.First()
                      .Subscribe(_ => Debug.Log("mouse clicked"));
        }
    }
}