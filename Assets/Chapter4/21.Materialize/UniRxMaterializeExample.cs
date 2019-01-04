/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class UniRxMaterializeExample : MonoBehaviour
    {
        void Start()
        {
            var subject = new Subject<int>();

            var onlyExceptions = subject.Materialize()
                                        .Where(notification => notification.Exception != null)
                                        .Dematerialize();

            subject.Subscribe(number => Debug.LogFormat("subcribe 1:{0}", number), e => Debug.LogFormat("subcribe excpetion 1:{0}", e));
            onlyExceptions.Subscribe(number => Debug.LogFormat("subcribe 2:{0}", number), e => Debug.LogFormat("subcribe excpetion 2:{0}", e));

            subject.OnNext(123);
            subject.OnError(new Exception("no this vlaue"));
        }
    }
}