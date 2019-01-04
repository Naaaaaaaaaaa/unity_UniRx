/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxSkipWhileExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .SkipWhile((_,times) => !Input.GetMouseButtonDown(0) && times < 100)
                      .Subscribe(_ => Debug.Log("mouse clicked"));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}