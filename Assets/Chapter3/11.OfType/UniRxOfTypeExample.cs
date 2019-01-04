/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System;
using System.Threading;
using System.Collections;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxOfTypeExample : MonoBehaviour
    {

        public class Enemy { public string Name { get; set; } };
        public class Boss : Enemy { };
        public class Monster : Enemy { };

        void Start()
        {
            var subject = new Subject<Enemy>();

            subject
                .OfType<Enemy, Boss>()
                .Subscribe(boss =>
            {
                Debug.Log(boss.Name);
            });

            subject.OnNext(new Boss { Name = "蘑菇王" });
            subject.OnNext(new Monster { Name = "蘑菇" });
            subject.OnNext(new Boss { Name = "阿龙" });

            subject.OnCompleted();
        }
    }
}