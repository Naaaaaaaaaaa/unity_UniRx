/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxTimeIntervalExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0)).Select(_ => "clicked")
                      .TimeInterval()
                      .Subscribe(timeInterval => Debug.LogFormat("{0},{1}", timeInterval.Interval, timeInterval.Value));
        }
    }
}