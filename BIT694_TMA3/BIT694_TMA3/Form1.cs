using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using PorterStemmerAlgorithm1;

namespace BIT694_TMA3
{
    public partial class Form1 : Form
    {
        private Indexing index; //A reference for a new Indexing object index
        private Thread thread; //A reference to thread
        private ThreadStart tStart; //A reference to tStart thread of BuildIndex

        public Form1()
        {
            InitializeComponent();
            index = new Indexing(); //initialize the Indexing class
            tStart = new ThreadStart(BuildIndex); //start thread for BuildIndex
            thread = new Thread(tStart); //instantiate a thread
        }

        //Code for when browse button is clicked
        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browsedFolder = new FolderBrowserDialog();
            if (browsedFolder.ShowDialog() == DialogResult.OK)
            {
                string folderPath = browsedFolder.SelectedPath;
                selectFolder.Clear();
                selectFolder.Text += folderPath; // select folder to textBox
            }
        }

        //Code for when Build Index button is clicked
        private void invertedIndex1_Click(object sender, EventArgs e)
        {
            {
                if (thread.IsAlive)
                {
                    MessageBox.Show("The index is currently busy. Please try again later"); //message shown if index building is in progress
                }
                else
                {
                    thread = new Thread(tStart); // re-instantiates the thread if it already exists
                    thread.Start(); // calls buildIndex on a new Thread
                }
            }
        }

        
        //The method launched on the new thread to build the inverted index
        private void BuildIndex()
        {
            index.internalIndex = index.InvertedIndex(selectFolder.Text);
            MessageBox.Show("Done");
        }

        //Code for when the refresh inverted index button is clicked
        private void invertedIndex2_Click(object sender, EventArgs e)
        {
            index = new Indexing();
            {
                if (thread.IsAlive)
                {
                    MessageBox.Show("The index is currently busy. Please try again later"); //message shown if index building is in progress
                }
                else
                {
                    thread = new Thread(tStart); // re-instantiates the thread if it already exists
                    thread.Start(); // calls buildIndex on a new Thread
                }
            }
        }

        //Code to display indexing statistics when display statistic button is clicked
        private void displayStatistics_Click(object sender, EventArgs e)
        {
            if (thread.IsAlive)
            {
                MessageBox.Show("The index is currently busy. Please try again later"); //message shown if index building is in progress
            }
            else
            {
                totalTerms.Text = index.indexCount.ToString(); //returns total terms
                int totalChars = 0;
                foreach (var item in index.internalIndex)
                {
                    totalChars = totalChars + item.Key.Length;
                }
                averageTerm.Text = Convert.ToDouble((double)totalChars / (double)index.indexCount).ToString(); //returns average term length
                var allFiles = Directory.GetFiles(selectFolder.Text, "*", SearchOption.AllDirectories).ToList();
                totalFiles.Text = allFiles.Count.ToString(); //returns number of files scanned

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            PorterStemmer stemmer = new PorterStemmer(); // instantiate a PorterStemmer object to stem words from files
            string stemmedWord = stemmer.StemWord(searchWord.Text); //stems the word before searching
            fileList.Text = " ";
            filesFound.Text = " ";

            List<string> files = new List<string>();
            bool found = false;
            if (thread.IsAlive)
            {
                MessageBox.Show("The index is currently busy. Please try again later"); //message shown if index building is in progress
            }
            else
            {
                foreach (var item in index.internalIndex)
                {
                    string newItem = StopWords.RemoveStopwords(item.Key);

                    if (newItem == stemmedWord)
                    {
                        found = true;
                        filesFound.Text = item.Value.Count.ToString();

                        foreach (var folderName in item.Value.Keys)
                        {
                            files.Add(folderName);
                        }
                    }

                }

                foreach (var file in files)
                {
                    fileList.Text += file + "\r\n";
                }
                if (!found)
                {
                    filesFound.Text = "0";
                    fileList.Text = "No results found";
                }
            }
        }
    }
}
