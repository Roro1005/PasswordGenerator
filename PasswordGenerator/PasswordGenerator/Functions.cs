using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    internal class Functions
    {

        public static (int,bool) ParseArgs(string[] args)
        {
            //桁数の特定
            if (args.Length < 1) return (10,true);

            int digits;
            if(!int.TryParse(args[0],out digits))
            {
                digits= 10;
            }

            //第二引数が存在して、"0"だったら記号は使わない
            if (args.Length < 2) return (digits, true);
            bool useMark = args[1] != "0";

            return (digits, useMark);
        }

        public static char GetRandomletter(char[] big,char[] little,char[]number,
                                           System.Random rand, bool useMark)
        {
            char[] target;
            //まずはどの配列から文字を選ぶかサイコロを振る
            int randMax;
            if (useMark)
                randMax = 4;
            else randMax = 3;
            switch(rand.Next(randMax))
            {
                case 3:
                    target = useMark;
                    break;
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
