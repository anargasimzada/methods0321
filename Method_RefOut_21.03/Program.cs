using System;
using System.ComponentModel.Design;
using System.Net;

namespace Method_RefOut_21._03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ədədlərdən ibarət arrayın mənfi elementlərini müsbətə çevirən method yazın.-------------TASK1------------------
            //int[] nums = { 15, -24, 48, 34, -58, 22 };
            //ChangePos(ref nums);
            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}
            //Daxil olunan mətndə "a" simvolunun olub olmadığını yoxlayın. Əgər varsa geriyə true qaytarsın.-------------------TASK2------------------------
            //string text = "Büyük düşünceler büyük bir zekadan çok, büyük bir kalpten doğarlar.";
            //Test(ref text);
            //Console.WriteLine(Test(ref text));
            //Min methodu yaradılır. Daxil olunan arrayın ən kiçik elementini tapır.-----------------------TASK3--------------------------
            //int[] nums = { 23, 12, 17, 45, 76, 34 };
            //Console.WriteLine(Min(ref nums));
            //NumLength methodu yaradılır. Daxil olunan ədədin rəqəmləri sayını tapır.-------------------------TASK4--------------------
            //int num = 11124;

            //NumLength(ref num);
            //VowelLetter yaradılır. Daxil olunan mətndə neçə sait hərf olduğunu tapsın.------------------------TASK5---------------------------
            //string text = "Acı ve üzüntü, vicdan ve derin bir yürek için her zaman zorunludur";
            //VowelLetter(ref text);
            //6. Göndərilən array-ın ədədi ortasını geri qaytaran method.--------------------------TASK6------------------------
            //int[] nums = { 3, 2, 6, 6, 3 };
            //NumAver(ref nums);
        }
        public static int NumAver(ref int[] arr)
        {
            int hide = 0;
            int count = 0;
            int average = 0;
            for(int i=0; i < arr.Length; i++)
            {                                                    //-------------TASK6----------------
                hide = hide + arr[i];
                count++;
            }
            average=hide/count;
            Console.WriteLine(average);
            return average;
        }






        public static void VowelLetter(ref string vowel)
        {
            int count = 0;
            string letter = "aıeəiöuüoAIEƏİÖUÜO";
            for (int i = 0; i < vowel.Length; i++)
            {
                for (int j = 0; j < letter.Length; j++)
                {                                                 //---------------------------TASK5-------------------------
                    if (vowel[i] == letter[j])
                    {
                        count += 1;
                    }

                }
            }
            Console.WriteLine(count);
        }









        public static void NumLength(ref int fig)
        {
            
            int count = 0;
            int hide ;
            while (fig != 0)
            {
                hide = fig % 10;                                  //-----------------------TASK4-----------------------------
                count++;
                fig = fig / 10;

            }

            Console.WriteLine(count);
        }




        public static int Min(ref int[] arr)
        {
            int hide = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < hide)                            //-------------------TASK3---------------------------------
                {
                    hide = arr[i];

                }
            }
            return hide;

        }





        public static bool Test(ref string testchar)
        {
            for (int i = 0; i < testchar.Length; i++)
            {
                if (testchar[i] == 'a')
                {
                    return true;                                     //--------------------TASK2-----------------------------
                }





            }
            return false;




        }




        public static void ChangePos(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= 0)
                {                                                  //--------------------TASK1-------------------------------
                    arr[i] *= -1;
                }
            }
            return;
        }
    }

}  
}
