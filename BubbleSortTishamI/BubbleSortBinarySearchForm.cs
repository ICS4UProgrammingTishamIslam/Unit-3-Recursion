using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BubbleSortTishamI
{
    public partial class BubbleSortBinarySearchForm : Form
    {
        public BubbleSortBinarySearchForm()
        {
            InitializeComponent();
            btnSort.Enabled = false;
            btnBinarySearch.Enabled = false;
            btnExport.Enabled = false;
            btnOutput.Enabled = false;
            btnRecursiveBinary.Enabled = false;
        }

        //our nice little array
        int[] niceArray;

        //and a bool to make sure that the reversings don't mess anything up
        bool reversed;

        private void BtnCreateArray_Click(object sender, EventArgs e)
        {
            //populate and then display the array
            niceArray = PopulateArray(niceArray, (int)nudArraySize.Value);
            DisplayArray(niceArray);
            btnSort.Enabled = true;
            btnExport.Enabled = true;
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            niceArray = BubbleSort(niceArray, chkReversed.Checked);
            DisplayArray(niceArray);
            btnBinarySearch.Enabled = true;
            btnOutput.Enabled = true;
            btnRecursiveBinary.Enabled = !chkReversed.Checked;

            reversed = chkReversed.Checked;
        }

        private void BtnBinarySearch_Click(object sender, EventArgs e)
        {
            int searched = BinarySearch(niceArray, (int)nudSearch.Value, chkApprox.Checked, reversed);

            if (searched == -2)
            {
                lblSearchVal.Text = "Huh, seems like I left a *loop*hole somewhere. Please submit a bug report to Tisham Islam promptly. Thanks!";
            }
            else if (searched == -1 && chkApprox.Checked == false)
            {
                lblSearchVal.Text = "The value you are looking for is not there";
            }
            else if (chkApprox.Checked == true)
            {
                lblSearchVal.Text = "The closest value to " + nudSearch.Value + " is found at index " + searched
                    + ". Which represents #" + (searched + 1) + " in this series."
                    + "The actual value is " + niceArray[searched];

            }
            else
            {
                lblSearchVal.Text = "The index of the search value " + nudSearch.Value + " is: " + searched
                    + ".\r\n You could also say it is #" + (searched + 1) + " in this series";
            }
        }

        #region Populating the Array
        public int[] PopulateArray(int[] toBeFilled, int size)
        {
            //set the array to given size, and create number generator
            toBeFilled = new int[size];
            Random numgen = new Random();

            //populate the array with numbers from 0-999
            for (int i = 0; i < size; i++)
            {
                toBeFilled[i] = numgen.Next(1000);
            }

            //return the filled array
            return toBeFilled;
        }
        #endregion

        #region Displaying the Array
        public void DisplayArray(int[] toBeSeen)
        {
            //the counter for array indexes
            int arrayCounter = 0;

            //counter for the amount of numbers in each line of numbers to be displayed
            int lineCounter = 25;

            //reset array text
            lblArray.Text = "";

            //while array counter is less than the array
            while (arrayCounter < toBeSeen.Length)
            {
                //if linecounter ends up being more than the array's length, 
                if (lineCounter > toBeSeen.Length)
                {
                    //shorten it to the array's length
                    lineCounter = toBeSeen.Length;
                }

                //and the array counter is less than the linecounter
                while (arrayCounter < lineCounter)
                {
                    //display the number in the array and increment the array counter
                    lblArray.Text += toBeSeen[arrayCounter] + "  ";
                    arrayCounter++;
                }

                //create a big line break before starting the next line
                lblArray.Text += "\r\n\r\n";
                lineCounter += 25;
            }
        }
        #endregion

        #region Bubble Sorting
        public int[] BubbleSort(int[] blower, bool reversed)
        {
            //vars
            bool switched;
            int placeHolder;

            if (!reversed)
            {
                do
                {
                    switched = false;
                    for (int i = 1; i < blower.Length; i++)
                    {

                        if (blower[i - 1] > blower[i])
                        {
                            placeHolder = blower[i];
                            blower[i] = blower[i - 1];
                            blower[i - 1] = placeHolder;
                            switched = true;
                        }
                    }
                } while (switched);
            }

            else
            {
                do
                {
                    switched = false;
                    for (int i = 1; i < blower.Length; i++)
                    {

                        if (blower[i - 1] < blower[i])
                        {
                            placeHolder = blower[i];
                            blower[i] = blower[i - 1];
                            blower[i - 1] = placeHolder;
                            switched = true;
                        }
                    }
                } while (switched);
            }
            return blower;
        }
        #endregion

        #region Binary Search
        public int BinarySearch(int[] toBeSearched, int searchVal, bool approx, bool rev)
        {
            //vars
            int lower = 0;
            int higher = toBeSearched.Length - 1;
            int middler = (int)Math.Floor((lower + higher) / 2.0);

            //while reverse is false, will go on until it returns a value
            while (!rev)
            {
                //if the middle value is the seach value
                if (toBeSearched[middler] == searchVal)
                {
                    //return the index
                    return middler;
                }
                //if the middle value is too high
                else if (toBeSearched[middler] > searchVal)
                {
                    //set the higher to the middle, and re-calculate the middle with the new higher
                    higher = middler;
                    middler = (int)Math.Floor((lower + higher) / 2.0);
                }
                //is the middle value is too low
                else if (toBeSearched[middler] < searchVal)
                {
                    //set the lower to the middle, and re calculate the middle
                    lower = middler;
                    middler = (int)Math.Floor((lower + higher) / 2.0);
                }

                //if the distance between the lower and the higher is by one
                if (lower == higher - 1)
                {
                    //if the function is permitted to approximate
                    if (approx)
                    {
                        //
                        int tmpLower = toBeSearched[lower];
                        int tmpHigher = toBeSearched[higher];

                        if (searchVal - tmpLower <= tmpHigher - searchVal)
                        {
                            return lower;
                        }
                        else
                        {
                            return higher;
                        }
                    }

                    else
                    {
                        if (toBeSearched[lower] == searchVal)
                        {
                            return lower;
                        }
                        else if (toBeSearched[higher] == searchVal)
                        {
                            return higher;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
                //while reverse iss true, will also go on until it returns a value
                //note that everything here is the same as above, but reversed
                while (rev)
            {
                if (toBeSearched[middler] == searchVal)
                {
                    return middler;
                }
                else if (toBeSearched[middler] < searchVal)
                {
                    higher = middler;
                    middler = (int)Math.Floor((lower + higher) / 2.0);
                }
                else if (toBeSearched[middler] > searchVal)
                {
                    lower = middler;
                    middler = (int)Math.Floor((lower + higher) / 2.0);
                }

                if (lower == higher - 1)
                {

                    if (approx)
                    {
                        int tmpLower = toBeSearched[lower];
                        int tmpHigher = toBeSearched[higher];
                        int tmpMiddler = toBeSearched[middler];

                        if (tmpHigher - searchVal <= searchVal - tmpLower)
                        {
                            return lower;
                        }

                        return higher;                        
                    }

                    else
                    {
                        if (toBeSearched[lower] == searchVal)
                        {
                            return lower;
                        }
                        else if (toBeSearched[higher] == searchVal)
                        {
                            return higher;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }

            //function thinks it might somehow reach this point, but it is actually wrong
            return -2;
        }

        #endregion

        //Day #27 (Recursive Binary Search)
        //Made on 8/11/2019 by Tisham Islam
        //Today I created a program that does binary search but recursively.
        int RBinarySearch(int[] arr, int left, int right, int SV)
        {
            //goes on until the right becomes less than the left, which means the value is not there
            //note that the only difference is that in java, arrays are declared differently. otherwise, it's the same
            if (right >= left)
            {
                int mid = left + (right - left) / 2;

                //if value is found, return the index
                if (arr[mid] == SV)
                {
                    return mid;
                }
                //if search value is smaller than the middle
                else if (arr[mid] > SV)
                {
                    //search in a lower range i.e. lower right
                    return RBinarySearch(arr, left, mid - 1, SV);
                }
                // if the search value is bigger than the middle
                else
                {
                    //search in a higher range i.e. higher left
                    return RBinarySearch(arr, mid + 1, right, SV);
                }
            }
            else
            {
                //return error message if val is not found
                return -1;
            }
        }

            private void BtnImport_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(txtInput.Text);
            string[] linesSplit = lines[0].Split(' ');
            niceArray = new int[linesSplit.Length];
            for (int i = 0; i < linesSplit.Length; i++)
            {
                niceArray[i] = int.Parse(linesSplit[i]);
            }
            DisplayArray(niceArray);
            btnSort.Enabled = true;
            btnExport.Enabled = true;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = new StreamWriter(txtExport.Text))
            {
                for (int i = 0; i < niceArray.Length; i++)
                {
                    file.Write(niceArray[i] + " ");
                }
            }
        }

        private void BtnOutput_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = new StreamWriter(txtOutput.Text))
            {
                int searched = BinarySearch(niceArray, (int)nudSearch.Value, chkApprox.Checked, reversed);

                if (searched == -2)
                {
                    file.Write("Huh, seems like I left a *loop*hole somewhere. Please submit a bug report to Tisham Islam promptly. Thanks!");
                }
                else if (searched == -1 && chkApprox.Checked == false)
                {
                    file.Write("The value you are looking for is not there");
                }
                else if (chkApprox.Checked == true)
                {
                    file.Write("The closest value to " + nudSearch.Value + " is found at index " + searched
                        + ". Which represents #" + (searched + 1) + " in this series."
                        + "The actual value is " + niceArray[searched]);
                }
                else
                {
                    file.Write("The index of the search value " + nudSearch.Value + " is: " + searched
                        + ".\r\n You could also say it is #" + (searched + 1) + " in this series");
                }
            }
        }

        private void BtnRecursiveBinary_Click(object sender, EventArgs e)
        {
            int searched = RBinarySearch(niceArray, 0, niceArray.Length - 1, (int)nudSearch.Value);

            if (searched == -1 && chkApprox.Checked == false)
            {
                lblSearchVal.Text = "The value you are looking for is not there";
            }
            else
            {
                lblSearchVal.Text = "The index of the search value " + nudSearch.Value + " is: " + searched
                    + ".\r\n You could also say it is #" + (searched + 1) + " in this series";
            }
        }
    }
}
