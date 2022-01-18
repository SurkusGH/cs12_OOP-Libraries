using Models;
using System;


namespace cs12_paskaita_OOP_Libraries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs12_PASKAITA_OOP_Libraries!");
            #region TEORIJA – OOP - BIBLIOTEKOS

            //
            // OOP Bibliotekos
            // Inkapsuliacija -  duomenų paslėpimas; mechanizmai
            // leidžiantys uždrausti tiesioginį priėjimą prie objekto komponentų
            // Konstukcijos leidžiančios apjungti metodus ir struktūras;
            //
            // Paveldėjimas -
            // 
            //
            //
            // Polimorfizmas -
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //

            #endregion

            Problem2();

        }

        public static void Problem1()
        {
            var invoice1 = new Invoice("Sender", 200.0m);
            var invoice2 = new Invoice("Sender", 200.0m);
            var invoice3 = new Invoice("Sender", 200.0m);
            var invoice4 = new Invoice("Sender", 200.0m);
            var invoice5 = new Invoice("Sender", 200.0m);
            var invoice6 = new Invoice("Sender", 200.0m);
            var invoice7 = new Invoice("Sender", 200.0m);
        }

        public static void Problem2()
        {
            // Sukurti struktūrą Palmė. Public laukai: amžius ir vaisiųKiekis.
            // Abu tik skaitymui. Sukurti Public Metodą pridėti1MenAmziaus().
            // Palmė duoda vaisius nuo 5 iki 12 mėnesio, paskui miršta,
            // t. y. amžius tampa 0. Vaisiu kiekis = amžius*3

            var Palm1 = new PalmTree(2, 0);
            var Palm2 = new PalmTree(4, 0);
            var Palm3 = new PalmTree(8, 0);
            var Palm4 = new PalmTree(9, 0);
            var Palm5 = new PalmTree(7, 0);

            Palm1.PritValues();
            Palm2.PritValues();
            Palm3.PritValues();
            Palm4.PritValues();
            Palm5.PritValues();
        }

        public static void Problem3()
        {
            // Sukurti struktūrą Point, public laukai x ir y tik skaitymui, perduodami
            // per konstruktorių. Sukurti struktūrą Rectangle, su public laukais:
            // TopLeft, BottomRight Point tipo.
            // Sukurti metodą bool isPointInRectangle(Point taškas)
        }
    }
}

