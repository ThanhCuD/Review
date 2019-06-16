using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Common
{
    
    public partial class Form1 : Form
    {
        /// <summary>
        /// Consts
        /// </summary>
        private class Consts
        {
            /// <summary>
            /// TabAndNewLine
            /// </summary>
            public const string TabAndNewLine = "\t\n";

            /// <summary>
            /// Tab
            /// </summary>
            public const string Tab = "\t";

            /// <summary>
            /// Root name of file XML
            /// </summary>
            public const string Root = "Root";

            /// <summary>
            /// NameOfXML
            /// </summary>
            public const string NameOfXML = "NameOfXML";

            /// <summary>
            /// NullLower
            /// </summary>
            public const string NullLower = "null";

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void GenXMl_Click(object sender, EventArgs e)
        {
            GenXML();
        }

        #region Method
        /// <summary>
        /// Gen XML from excel
        /// </summary>
        private void GenXML()
        {
            // read from RictTextBox
            string text = richTextBox1.Text;
            // push every element in to a Array
            var arrDoc = Regex.Split(text, Consts.TabAndNewLine);
            // take values of all
            var arrNote = arrDoc.Take(arrDoc.Length - 1).Skip(1).Select(x => Regex.Split(x, Consts.Tab)).ToArray();
            // Take name of element
            var nameElement = Regex.Split(arrDoc[0], Consts.Tab);

            XmlDocument doc = new XmlDocument();
            // Create a root
            XElement xml = new XElement(Consts.Root);

            // loop them arrNote
            for (int i = 0; i < arrNote.Length; i++)
            {
                // check Null or empty 
                var nameOfXMl = !string.IsNullOrEmpty(txtNameOfClass.Text.Trim()) ? txtNameOfClass.Text.Trim() : Consts.NameOfXML;

                // create elements
                XElement elements = new XElement(nameOfXMl);
                for (int j = 0; j < nameElement.Length; j++)
                {
                    // Check null for value elment
                    if (arrNote[i][j].ToLower() != Consts.NullLower)
                    {
                        XElement element = new XElement(nameElement[j], arrNote[i][j]);
                        elements.Add(element);
                    }
                }
                // Add them
                xml.Add(elements);
            }
            // show xml 
            rtbXml.Text = xml.ToString();
        }
        #endregion

    }
}
