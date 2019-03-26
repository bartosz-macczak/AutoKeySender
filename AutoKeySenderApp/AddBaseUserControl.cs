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
    public partial class AddBaseUserControl : UserControl
    {
        public string login { get; set; }
        DataBaseClass DB = new DataBaseClass();

        public AddBaseUserControl()
        {
            InitializeComponent();
        }

        private void addBaseButton_Click(object sender, EventArgs e)
        {

            DB.createCodeBase(login, baseNameTextBox.Text);
        }
    }
}
