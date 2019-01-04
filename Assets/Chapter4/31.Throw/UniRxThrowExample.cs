/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using System;
using UniRx;
using UnityEngine;

namespace UniRxLesson
{
    public class UniRxThrowExample : MonoBehaviour
    {
        void Start() 
        {
            Observable.Throw<string>(new Exception("error"))
                      .Subscribe(_ => Debug.Log("不会输出"), e => Debug.LogFormat("发现异常:{0}", e.Message));
        }
    }
}