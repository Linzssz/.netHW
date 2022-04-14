using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class photo : Form
    {
        public photo()
        {
            InitializeComponent();
        }

        private void myTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.myTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.photoDatabaseDataSet);

        }

        private void photo_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'photoDatabaseDataSet.myTable' 資料表。您可以視需要進行移動或移除。
            this.myTableTableAdapter.Fill(this.photoDatabaseDataSet.myTable);

        }
    }
}
