/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace UniRxLesson
{
    public class UniRxConcatExample : MonoBehaviour
    {
        void Start()
        {
            var leftMouseClickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)).Take(3).Select(_ => "A");
            var rightMouseClickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(1)).Take(2).Select(_ => "B");

            leftMouseClickStream.Concat(rightMouseClickStream)
                                .Subscribe(clickEvent =>
                                {
                                    Debug.Log(clickEvent);
                                });
        }
    }
}