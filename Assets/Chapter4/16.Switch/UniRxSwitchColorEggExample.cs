/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxSwitchColorEggExample : MonoBehaviour
    {
        void Start()
        {
            // w a s d
            var wObservable = Observable.EveryUpdate().Where(_ => Input.GetKeyDown(KeyCode.W));
            var aObservable = Observable.EveryUpdate().Where(_ => Input.GetKeyDown(KeyCode.A));
            var sObservable = Observable.EveryUpdate().Where(_ => Input.GetKeyDown(KeyCode.S));
            var dObservable = Observable.EveryUpdate().Where(_ => Input.GetKeyDown(KeyCode.D));

            wObservable
                .Select(_ => aObservable)
                .Switch()
                .Select(_ => sObservable)
                .Switch()
                .Select(_ => dObservable)
                .Switch()
                .Repeat()
                .Subscribe(_ => Debug.Log("触发彩蛋"));
        }
    }
}