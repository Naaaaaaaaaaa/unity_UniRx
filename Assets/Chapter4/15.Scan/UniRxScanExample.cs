/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxScanExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .Scan(0, (times, nextValue) => ++times)
                      .Subscribe(times => Debug.LogFormat("clicked {0} times", times));
        }
    }
}