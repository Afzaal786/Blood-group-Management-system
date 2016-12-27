using BB_DAL_EF;
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
using System.Windows.Shapes;

namespace BB_Project
{
    /// <summary>
    /// Interaction logic for Insert_Blood_Group.xaml
    /// </summary>
    public partial class Insert_Blood_Group : Window
    {
        public Insert_Blood_Group()
        {
            InitializeComponent();
        }

        private void btn_BG_Save_Click(object sender, RoutedEventArgs e)
        {
            Blood_Group bld_grp = new Blood_Group();
            bld_grp.Group_Name = txtName.Text;
            BloodGroupValidation BGV = new BloodGroupValidation();
            if (BGV.InsertGroup(bld_grp))
            {
                MessageBox.Show("Inserted");
                txtName.Clear();
            }
            else
                MessageBox.Show("Not Inserted");
            txtName.Focus();
        }   
    }
}
