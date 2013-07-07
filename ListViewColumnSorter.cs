using System.Collections;
using System.Windows.Forms;

namespace Stealth_Compressor
{
    // ListView Sorting Class
    public class ListViewColumnSorter : IComparer
    {
        private int ColumnToSort;
        private SortOrder OrderOfSort;
        private CaseInsensitiveComparer ObjectCompare;

        public ListViewColumnSorter()
        {
            // Initialize the column to '0'
            ColumnToSort = 0;

            // Initialize the sort order to 'none'
            OrderOfSort = SortOrder.None;

            // Initialize the CaseInsensitiveComparer object
            ObjectCompare = new CaseInsensitiveComparer();
        }
        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;

            // Cast the objects to be compared to ListViewItem objects
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            double numX;
            double numY;

            // Compare the two items as numbers if the column is for filesize
            if (double.TryParse(listviewX.SubItems[ColumnToSort].Text, out numX) &&
                double.TryParse(listviewY.SubItems[ColumnToSort].Text, out numY) &&
                ColumnToSort == 2)
            {
                compareResult = ObjectCompare.Compare(numX, numY);
            }

            // Otherwise compare the items as strings
            else
            {
                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text,
                                                      listviewY.SubItems[ColumnToSort].Text);
            }


            // Calculate correct return value based on object comparison
            if (OrderOfSort == SortOrder.Ascending)
            {
                // Ascending sort is selected, return normal result of compare operation
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending)
            {
                // Descending sort is selected, return negative result of compare operation
                return (-compareResult);
            }
            else
            {
                // Return '0' to indicate they are equal
                return 0;
            }
        }
        public int SortColumn
        {
            set { ColumnToSort = value; }
            get { return ColumnToSort; }
        }
        public SortOrder Order
        {
            set { OrderOfSort = value; }
            get { return OrderOfSort; }
        }
    }
}
