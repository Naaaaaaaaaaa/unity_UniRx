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
    public class UniRxCombineLatestExample : MonoBehaviour
    {
        void Start()
        {
            var a = 0;
            var i = 0;

            var leftStream = this.UpdateAsObservable().Where(_ =>Input.GetMouseButtonDown(0)).Select(_ => (++a).ToString());
            var rightStream = this.UpdateAsObservable().Where(_ =>Input.GetMouseButtonDown(1)).Select(_ => (++i).ToString());

            leftStream.CombineLatest(rightStream, (left, right) => left + right)
                .Subscribe(Debug.Log);
        }
    }
}