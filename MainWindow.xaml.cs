/*
 * Couper Ebbs-Picken
 * 4/23/2018
 * Takes a whole lotta words from a dictionary and removes all the words with more than seven letters
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace u3_Scrabble_WordsIntoTextFiles_Couper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // tries this code
            try
            {
                // initializes a stream reader and writer
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter("Words.txt");
                System.IO.StreamReader streamReader = new System.IO.StreamReader("ListOfWords.txt");

                // loop that runs through all the lines
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();

                    // checks if the word has more than 7 letters unless the word is a or I
                    if (line.Length < 8)
                    {
                        if (line.Length != 1
                            && line != "a"
                            && line != "I")
                        {
                            streamWriter.Write(line + "\r" + "\n");
                        }
                        if (line == "a"
                            || line == "I")
                        {
                            streamWriter.Write(line + "\r" + "\n");
                        }
                    }
                }

                // closes the writer and reader
                streamWriter.Flush();
                streamWriter.Close();
                streamReader.Close();
            }

            // catches if there is an error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }
    }
}
