/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System.Collections.Generic;

namespace UniRxLesson
{
    public class SelectManyExample : MonoBehaviour
    {
        void Start()
        {
            var urls = new List<string> { "http://sikiedu.com", "http://qframework.com" };
            urls.SelectMany(url => "[" + url + "]")
                .ToList()
                .ForEach(singleChar=>{
                    Debug.Log(singleChar);
            });
        }
    }
}
