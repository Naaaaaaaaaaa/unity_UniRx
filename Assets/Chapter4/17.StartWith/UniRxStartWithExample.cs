/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxStartWithExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Return("sikiedu.com")
                      .StartWith("http", "://")
                      .Aggregate((current, next) => current + next)
                      .Subscribe(Debug.Log);
        }
    }
}