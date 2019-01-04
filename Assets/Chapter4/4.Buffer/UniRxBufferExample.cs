/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;
using UniRx.Triggers;

namespace UniRxLesson
{
    public class UniRxBufferExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Interval(TimeSpan.FromSeconds(1.0f))
                      .Buffer(TimeSpan.FromSeconds(4.0f))
                      .Subscribe(countList =>
                      {
                          Debug.Log("countList");
                          countList.ToList()
                                   .ForEach(count => Debug.Log(count));
                      });
        }
    }
}