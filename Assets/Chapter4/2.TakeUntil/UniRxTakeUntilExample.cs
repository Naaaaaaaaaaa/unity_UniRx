/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class UniRxTakeUntilExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .TakeUntil(Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)))
                      .Subscribe(_ => Debug.Log("123"));
        }
    }
}
