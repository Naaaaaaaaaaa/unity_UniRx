/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Collections.Generic;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxDistinctExample : MonoBehaviour
    {
        void Start()
        {
            var leftMouseClickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)).Select(_ => "LeftMouseClicked");
            var rightMouseClickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(1)).Select(_ => "RightMouseClicked");

            Observable.Merge(leftMouseClickStream, rightMouseClickStream)
                      .Distinct()
                      .Subscribe(mouseEvent =>
                      {
                          Debug.Log(mouseEvent);
                      });
        }
    }
}