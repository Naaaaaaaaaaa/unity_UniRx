/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxMergeExample : MonoBehaviour
    {
        void Start()
        {
            var leftClickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)).Select(_ => "A");
            var rightClickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(1)).Select(_ => "B");

            leftClickStream.Merge(rightClickStream, rightClickStream)
                           .Subscribe(clickEventName => Debug.Log(clickEventName));
        }
    }
}