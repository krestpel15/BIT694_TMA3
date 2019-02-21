using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BIT694_TMA3
{
    class ScanFiles
    {
        List<string> fileWords = new List<string>(); //A reference to the list of file words scanned

        //Scan the dictionary
        public static List<String> scanFiles(string files)
        { 
            String myLine;
            String fileWords = "";

            TextReader tr = new StreamReader(files);
            try
            {
                while ((myLine = tr.ReadLine()) != null) //read the files
                {
                    fileWords += myLine + " ";
                }
            }
            catch (FileNotFoundException error)
            {
                MessageBox.Show("File not found" + error);
            }
            return AddTextToList(fileWords);
        }

        //adds scanned words to list
        private static List<string> AddTextToList(string myTextInput)
        {
            List<string> fileWords = new List<string>();
            
            string myText = myTextInput;
            myText.Replace(Environment.NewLine, " ");

            
            myText = StopWords.RemoveStopwords(myText); //removes stopwords

            // remove numbers, punctuation & special characters from each line and make lower case
            String aText = Regex.Replace(myText, "[^a-zA-Z\\s+]", ""); //replace punctuations and numbers with blank space
            aText = aText.ToLower();

            String[] words = aText.Split(' '); //Splitting a line into an array of words

            foreach (string word in words)
            {

                if (word != "")
                {
                    
                    fileWords.Add(word);
                }

            }

            return fileWords;
        }
        
    }
}





