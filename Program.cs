using System;
using System.Collections.Generic;

namespace PrepSamplePayloadForHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get content
            string content = System.IO.File.ReadAllText(@"C:\Users\tahan\Downloads\Payload.txt");
            string[] lines = content.Split(Environment.NewLine);

            //Convert 1 by 1
            List<string> ToWrite = new List<string>();
            foreach (string s in lines)
            {
                //Take out the tabs
                string nl = s.Replace("\t", "<tabspace></tabspace>");
                nl = nl.Replace("    ", "<tabspace></tabspace>");
                ToWrite.Add(nl + "<br>");
            }

            //Assemble
            string all = "";
            foreach (string s in ToWrite)
            {
                all = all + s + Environment.NewLine;
            }
            all = all.Substring(0, all.Length - 1);

            //Write it
            System.IO.File.WriteAllText(@"C:\Users\tahan\Downloads\ResultPayload.txt", all);

            
        }
    }
}
