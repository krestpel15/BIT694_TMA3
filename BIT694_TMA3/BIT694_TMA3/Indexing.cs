using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using InvertedIndex_Ex1;
using PorterStemmerAlgorithm1;
using System.IO;
using System.Windows.Forms;
namespace BIT694_TMA3
{
    class Indexing
    {
        private Converter converter; // A reference to the Converter class
        internal Dictionary<string, Dictionary<string, double>> internalIndex; // A reference to the invertedIndex available in all classes in the assembly
        internal int indexCount; //A reference to the index counter

        //folders to be indexed
        public List<string> IndexingFolders(string folder)
        {
            return Directory.GetFiles(folder, "*", SearchOption.AllDirectories).ToList();
        }

        //inverted index
        public Dictionary<string, Dictionary<string, double>> InvertedIndex(string folder)
        {
            converter = new Converter();
            if (internalIndex != null) { internalIndex.Clear(); } // clears the memory usage of exisitng Index
            internalIndex = new Dictionary<string, Dictionary<string, double>>(); // the invertedIndex to be returned
            indexCount = 0; // a counter for how large the inverted index is.

            Dictionary<string, double> fileList = new Dictionary<string, double>(); // a list to populate the files that match a term
            PorterStemmer stemmer = new PorterStemmer(); // instantiate a PorterStemmer object to stem words from files

            foreach (string file in IndexingFolders(folder))
            {
                //int fileID = converter.assignID(file); // create an Id from the string of the file and store in HashMap Converter.paths
                
                foreach (string word in ScanFiles.scanFiles(file))
                {
                    // stem the word
                    string stemmedWord = stemmer.StemWord(word);

                    // create the Dictionary for the collection
                    if (internalIndex.ContainsKey(stemmedWord))
                    {
                        fileList = internalIndex[stemmedWord];

                        // check if the file is already in the list or not
                        if (fileList.ContainsKey(file))
                        {
                            fileList[file] = double.Parse(fileList[file].ToString()) + 1;
                        }
                        else
                        {
                            fileList.Add(file, 1.0);
                        }

                        internalIndex[stemmedWord] = fileList;
                    }
                    else
                    {
                        // create a new key and start new List of files for the key
                        fileList = new Dictionary<string, double>
                        {
                            { file, 1.0 }
                        };
                        internalIndex.Add(stemmedWord, fileList);
                        indexCount++;
                    }
                }
            }
            return internalIndex;
        }

    }
}
