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
    public class UniRxSkipUntilExample : MonoBehaviour
    {
        void Start()
        {
            // 条件
            var clickStream = this.UpdateAsObservable().Where(_ => Input.GetMouseButtonDown(0));

            // 监听
            this.UpdateAsObservable()
                .SkipUntil(clickStream)
                .Take(100)
                .Repeat()
                .Subscribe(_ => Debug.Log("mouse clicked"));
        }
    }
}