/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class LINQRepeatExample : MonoBehaviour
    {
        void Start()
        {
            Enumerable.Repeat("http://sikiedu.com", 10)
                      .ToList()
                      .ForEach(url => Debug.Log(url));
        }
    }
}