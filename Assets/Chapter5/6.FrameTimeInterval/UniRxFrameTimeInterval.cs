/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxFrameTimeInterval : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .FrameTimeInterval()
                      .Subscribe(timeInterval => Debug.LogFormat("observable 1:{0}", timeInterval.Interval));


            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .TimeInterval()
                      .Subscribe(timeInterval => Debug.LogFormat("observable 2:{0}", timeInterval.Interval));
        }
    }
}