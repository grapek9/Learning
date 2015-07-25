using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spojApps
{
    class FLAMASTE
    {
        public void run()
        {
            Console.WriteLine("Number of tests ?");
            String input;
            try
            {
                input = Console.ReadLine();
                int range = Int32.Parse(input);
                String[] text = new String[range];
                for (int i = 0; i < range; i++)
                {
                    input = Console.ReadLine();
                    text[i] = input;
                }
                foreach (String iterator in text)
                {
                    shortenTextDisplay(iterator);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void shortenTextDisplay(String text)
        {
            text = text.ToUpper();
            
            int length = text.Length, counter=1;
            String template, shortenString="";
            template = text[0].ToString();
            for(int i =1;i<text.Length;i++){
                if(template.Equals(text[i].ToString())){
                    counter++;
                }
                else
                {
                    if (counter < 2)
                    {
                        shortenString += template;
                    }else if(counter == 2){
                        shortenString += template + template;
                    }
                    else
                    {
                        shortenString += template + counter.ToString();
                    }
                    template = text[i].ToString();
                    counter = 1;
                }
                if (i == text.Length - 1)
                {
                    if (counter < 2)
                    {
                        shortenString += template;
                    }
                    else if (counter == 2)
                    {
                        shortenString += template + template;
                    }
                    else
                    {
                        shortenString += template + counter.ToString();
                    }
                }

            }
            Console.WriteLine(shortenString);
        }
    }
}
