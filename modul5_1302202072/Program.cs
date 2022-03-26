using System;

namespace modul5_1302202072 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user1 = new SayaTubeUser("razqy");
            try {
                SayaTubeVideo video1 = new SayaTubeVideo("review film jujutsu kaisen 0 oleh razqy");
                video1.IncreasePlayCount(123123);

                user1.addVideo(video1);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {

                SayaTubeVideo video2 = new SayaTubeVideo("review film mafia oleh razqy");
                video2.IncreasePlayCount(123123);


                user1.addVideo(video2);

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {

                SayaTubeVideo video3 = new SayaTubeVideo("review film mafia2 oleh razqy");
                video3.IncreasePlayCount(123123);
                user1.addVideo(video3);

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {

                SayaTubeVideo video4 = new SayaTubeVideo("review film batman darknight returns oleh razqy");
                video4.IncreasePlayCount(123123);
                user1.addVideo(video4);
 
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {

                SayaTubeVideo video5 = new SayaTubeVideo("review film shawshank redemption oleh razqy");
                video5.IncreasePlayCount(123123);
                user1.addVideo(video5);

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {

                SayaTubeVideo video6 = new SayaTubeVideo("review film deadpool oleh razqy");
                video6.IncreasePlayCount(123123);
                user1.addVideo(video6);

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                SayaTubeVideo video7 = new SayaTubeVideo("review film deadpool2 oleh razqy");
                video7.IncreasePlayCount(123123);
                user1.addVideo(video7);

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                SayaTubeVideo video8 = new SayaTubeVideo("review film peaky blinders oleh razqy");
                video8.IncreasePlayCount(123123);
                user1.addVideo(video8);

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                SayaTubeVideo video9 = new SayaTubeVideo("review film Josee, The tiger and The fish oleh razqy");
                video9.IncreasePlayCount(26000000);
                user1.addVideo(video9);

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            try
            {
                SayaTubeVideo video10 = new SayaTubeVideo("review film avanger oleh razqy");
                video10.IncreasePlayCount(123123);
                user1.addVideo(video10);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

   

            user1.PrintAllVideoPlayvoutn();

            Console.WriteLine("Total viewers:\n"+user1.getTotalVideoPlayCount());

        }
    }
}