/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System.Collections.Generic;

namespace UniRxLesson
{
    public class UniRxGroupByExample : MonoBehaviour
    {
        void Start()
        {
            var subject = new Subject<int>();

            //subject.GroupBy(number => number % 2 == 0 ? "偶数" : "奇数")
                   //.Subscribe(numberGroup =>
                   //{
                   //    numberGroup.Subscribe(number =>
                   //    {
                   //        Debug.LogFormat("GroupKey:{0} Number:{1}", numberGroup.Key, number);
                   //    });
                   //});

            (from number in subject
             group number by number % 2 == 0 ? "偶数" : "奇数" into numberGroup
             select numberGroup)
             .Subscribe(numberGroup =>
             {
                 numberGroup.Subscribe(number =>
                 {
                     Debug.LogFormat("GroupKey:{0} Number:{1}", numberGroup.Key, number);
                 });
             });

            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnNext(4);
            subject.OnNext(5);

            subject.OnCompleted();




        }
    }
}