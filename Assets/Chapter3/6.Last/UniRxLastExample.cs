/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxLastExample : MonoBehaviour
    {
        void Start()
        {
            // completed
            var obserble = Observable.Create<int>(observer =>
            {
                observer.OnNext(3);
                observer.OnNext(2);
                observer.OnNext(1);
                observer.OnCompleted();
                return Disposable.Create(() => { Debug.Log("dispose"); });
            });

            obserble.Last(number=>number > 2)
                    .Subscribe(value =>
                    {
                        Debug.Log(value);
                    });
        }
    }
}