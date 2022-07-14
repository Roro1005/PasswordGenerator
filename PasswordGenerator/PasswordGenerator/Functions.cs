using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    internal class Functions
    {
        public static char GetRandomletter(char[] big,char[] little,char[]number,
                                           System.Random rand)
        {
            char[] target;
            //まずはどの配列から文字を選ぶかサイコロを振る
            switch(rand.Next(3))
            {
                case 0:
                    target = big;
                    break;
                case 1:
                    target = little;
                    break;
                default:
                    target = number;
                    break;
            }

            //次にtargetの中からランダムな文字列を選ぶ
            return target[rand.Next(target.Length)];
        }
    }
}
