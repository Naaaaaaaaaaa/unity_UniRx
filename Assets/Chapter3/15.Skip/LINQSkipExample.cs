/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System.Collections.Generic;

namespace UniRxLesson
{
    public class LINQSkipExample : MonoBehaviour
    {
        private void Start()
        {
            var grades = new[] { 99, 100, 99, 50, 100, 10 };

            grades.OrderByDescending(x => x)
                  .Skip(2)
                  .ToList()
                  .ForEach(grade => Debug.Log(grade));
        }
    }
}