/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxDeferExample : MonoBehaviour
    {
        void Start()
        {
            var deferRandom = new System.Random();

            var deferRangeStream = Observable.Defer(() => Observable.Start(deferRandom.Next));

            deferRangeStream.Subscribe(number => Debug.LogFormat("1st subscribe:number {0}", number));
            deferRangeStream.Subscribe(number => Debug.LogFormat("2st subscribe:number {0}", number));


            var random = new System.Random();
            var rangeStream = Observable.Start(random.Next);

            rangeStream.Subscribe(number => Debug.LogFormat("3st subscribe:number {0}", number));
            rangeStream.Subscribe(number => Debug.LogFormat("4st subscribe:number {0}", number));
        }
    }
}