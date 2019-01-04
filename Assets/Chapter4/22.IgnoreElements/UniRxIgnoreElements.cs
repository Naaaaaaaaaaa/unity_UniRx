/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;

namespace UniRxLesson
{
    public class UniRxIgnoreElements : MonoBehaviour
    {
        void Start()
        {
            var subject = new Subject<int>();

            var noElements = subject.IgnoreElements();

            subject.Subscribe(number => Debug.LogFormat("subject.OnNext({0})", number), () => Debug.Log("subject.OnCompleted()"));
            noElements.Subscribe(number => Debug.LogFormat("noElements.OnNext({0})", number), () => Debug.Log("noElements.OnCompleted()"));

            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);

            subject.OnCompleted();
        }
    }
}