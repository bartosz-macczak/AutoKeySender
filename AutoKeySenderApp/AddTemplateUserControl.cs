using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKeySenderApp
{
    public partial class AddTemplateUserControl : UserControl
    {
        public string login;
        DataBaseClass DB = new DataBaseClass();

        public AddTemplateUserControl()
        {
            InitializeComponent();
        }

        private void addTemplateButton_Click(object sender, EventArgs e)
        {
            createTemplate(templateNameTextBox.Text, addTemplateRichTextBox.Text);
        }

        //Create new template
        private void createTemplate(string templateName, string templateText)
        {
            DB.executeDB("INSERT INTO `templates_" + login + "`(name, text) VALUES('" + templateName + "', '"+templateText+"')");
            templateNameTextBox.Clear();
            addTemplateRichTextBox.Clear();
            MessageBox.Show("Dodano szablon.");
        }
    }
}
