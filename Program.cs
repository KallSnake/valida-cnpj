using System;

namespace ValidaCNPJ
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Write("informe seu CNPJ: ");
            string cnpj = Console.ReadLine();


            // Console.WriteLine("Seu CPF: " + cnpj);


            string n1 = (cnpj.Substring(0, 1));

            // Console.WriteLine("Pos 1: " + n1); // ok

            string n2 = (cnpj.Substring(1, 1));

            // Console.WriteLine("Pos 2: " + n2); // ok

            string n3 = (cnpj.Substring(2, 1));

            // Console.WriteLine("Pos 3: " + n3); // ok

            string n4 = cnpj.Substring(3, 1);

            // Console.WriteLine("Pos 4: " + n4); // ok

            string n5 = cnpj.Substring(4, 1);

            // Console.WriteLine("Pos 5: " + n5); // ok

            string n6 = cnpj.Substring(5, 1);

            // Console.WriteLine("Pos 6: " + n6); // ok

            string n7 = cnpj.Substring(6, 1);

            // Console.WriteLine("Pos 7: " + n7); // ok

            string n8 = cnpj.Substring(7, 1);

            // Console.WriteLine("Pos 8: " + n8); // ok

            string n9 = cnpj.Substring(8, 1);

            // Console.WriteLine("Pos 9: " + n9); // ok

            string n10 = cnpj.Substring(9, 1);

            // Console.WriteLine("Pos 10: " + n10); // ok

            string n11 = cnpj.Substring(10, 1);

            // Console.WriteLine("Pos 11: " + n11); // ok

            string n12 = cnpj.Substring(11, 1);

            // Console.WriteLine("Pos 12: " + n12); // ok

            string n13 = cnpj.Substring(12, 1);

            // Console.WriteLine("Pos 13: " + n13); // ok

            string n14 = cnpj.Substring(13, 1);

            // Console.WriteLine("Pos 14: " + n14); // ok


            float sum1 = 0f;
            float sum2 = 0f;
            float res1 = 0f;
            float res2 = 0f;


            if ((!cnpj.Length.Equals(14)) || (cnpj.Equals("00000000000000")) || (cnpj.Equals("11111111111111")) || (cnpj.Equals("22222222222222")) || (cnpj.Equals("33333333333333")) || (cnpj.Equals("44444444444444")) || (cnpj.Equals("55555555555555")) || (cnpj.Equals("66666666666666")) || (cnpj.Equals("77777777777777")) || (cnpj.Equals("88888888888888")) || (cnpj.Equals("99999999999999")))
            {

                Console.WriteLine();
                Console.WriteLine("informe seu CNPJ corretamente!");

            }
            else
            {


                sum1 = ((Convert.ToSingle(n1) * 5) + (Convert.ToSingle(n2) * 4) + (Convert.ToSingle(n3) * 3) + (Convert.ToSingle(n4) * 2) + (Convert.ToSingle(n5) * 9) + (Convert.ToSingle(n6) * 8) + (Convert.ToSingle(n7) * 7) + (Convert.ToSingle(n8) * 6) + (Convert.ToSingle(n9) * 5) + (Convert.ToSingle(n10) * 4) + (Convert.ToSingle(n11) * 3) + (Convert.ToSingle(n12) * 2));

                Console.WriteLine();
                // Console.WriteLine("Soma 1: " + sum1);

                res1 = (sum1 * 10) % 11;

                Console.WriteLine();
                // Console.WriteLine("Resto 1: " + res1);


                if (res1.Equals(10))
                {

                    res1 = 0;

                }


                sum2 = ((Convert.ToSingle(n1) * 6) + (Convert.ToSingle(n2) * 5) + (Convert.ToSingle(n3) * 4) + (Convert.ToSingle(n4) * 3) + (Convert.ToSingle(n5) * 2) + (Convert.ToSingle(n6) * 9) + (Convert.ToSingle(n7) * 8) + (Convert.ToSingle(n8) * 7) + (Convert.ToSingle(n9) * 6) + (Convert.ToSingle(n10) * 5) + (Convert.ToSingle(n11) * 4) + (Convert.ToSingle(n12) * 3) + (Convert.ToSingle(n13) * 2));

                Console.WriteLine();
                // Console.WriteLine("Soma 2: " + sum2);

                res2 = (sum2 * 10) % 11;

                Console.WriteLine();
                // Console.WriteLine("Resto 2: " + res2);


                if (res2.Equals(10))
                {

                    res2 = 0;

                }


                if ((res1.Equals(Convert.ToSingle(n13))) && res2.Equals(Convert.ToSingle(n14)))
                {

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("CNPJ válido!");

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("CNPJ inválido!");

                }



            }


            Console.WriteLine();
            Console.WriteLine();


            Console.ReadKey();



        }
    }
}
