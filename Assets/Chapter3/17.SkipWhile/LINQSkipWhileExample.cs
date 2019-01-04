/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class LINQSkipWhileExample : MonoBehaviour
    {
        void Start()
        {
            new[] { 80, 80, 98, 99, 79, 70, 86, 100 }
                  .OrderByDescending(grade => grade)
                  .SkipWhile(grade => grade >= 80)
                  .ToList()
                  .ForEach(grade => Debug.Log(grade));
        }
    }
}