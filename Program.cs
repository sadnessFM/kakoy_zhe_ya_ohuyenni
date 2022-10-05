using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace kakoy_zhe_ya_ohuyenni
{
    internal class Program
    {
        public static void Main()
        {
            List<jpegaioegjiowrajioer> berba = new List<jpegaioegjiowrajioer>
            {
                new jpegaioegjiowrajioer("Winkles?", "twinkles"),
                new jpegaioegjiowrajioer("O'er the?", "flood"),
                new jpegaioegjiowrajioer("Ordinary?", "days v2"),
                new jpegaioegjiowrajioer("Personal?", "jesus"),
                new jpegaioegjiowrajioer("Real?", "hero"),
                new jpegaioegjiowrajioer("sunset?", "girl"),
                new jpegaioegjiowrajioer("you dance like?", "a june sky"),
                new jpegaioegjiowrajioer("Plastic?", "love"),
                new jpegaioegjiowrajioer("kiss in?", "october")
            };
            
            List<string> answer = new List<string>();
            
            
            foreach (jpegaioegjiowrajioer t in berba)
            {
                Console.WriteLine($"\n{t.Question}");
                answer.Add(Console.ReadLine());
            }
            
            int percentage = (from x in berba from y in answer 
                where y == x.Answer select 10).Sum();

            Console.WriteLine($"\nYou have got {percentage}% of answers correctly");
            
            File.WriteAllText(@".\bebra.json", JsonSerializer.Serialize(berba));
            File.WriteAllText(@".\ansewre.json", JsonSerializer.Serialize(answer));
        }
    }
}
