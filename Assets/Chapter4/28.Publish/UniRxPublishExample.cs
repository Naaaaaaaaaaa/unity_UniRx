/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System;

namespace UniRxLesson
{
    public class UniRxPublishExample : MonoBehaviour
    {
        void Start()
        {
            var unShared = Observable.Range(1, 3);

            unShared.Subscribe(number => Debug.LogFormat("unShared Observable #1:{0}", number));
            unShared.Subscribe(number => Debug.LogFormat("unShared Observable #2:{0}", number));

            var shared = unShared.Publish();

            shared.Subscribe(number => Debug.LogFormat("shared Observable #1:{0}", number));
            shared.Subscribe(number => Debug.LogFormat("shared Observable #2:{0}", number));

            Observable.Timer(TimeSpan.FromSeconds(3.0f))
                      .Subscribe(_ => shared.Connect());

        }
    }
}
