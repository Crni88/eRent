using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;


namespace eRent.UI
{
    public partial class frmIzvjestaj : Form
    {
        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\output.pdf"));

            // create a new document instance
            Document doc = new Document(pdfDoc);

            // create a new table with 3 columns
            Table table = new Table(3);

            // add table headers
            table.AddHeaderCell("Column 1");
            table.AddHeaderCell("Column 2");
            table.AddHeaderCell("Column 3");

            // add table rows
            table.AddCell("Row 1, Column 1");
            table.AddCell("Row 1, Column 2");
            table.AddCell("Row 1, Column 3");
            table.AddCell("Row 2, Column 1");
            table.AddCell("Row 2, Column 2");
            table.AddCell("Row 2, Column 3");

            // add the table to the document
            doc.Add(table);

            // close the document
            doc.Close();
        }
    }
}
