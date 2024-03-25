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
using Models_and_Services;

namespace ComputerStore.MVVM.View
{
    
    public partial class EmployeeView : UserControl
    {
        private readonly ComputerStoreDBContext _dbContext;

        public EmployeeView(ComputerStoreDBContext dbcontext)
        {
            InitializeComponent();
            _dbContext = dbcontext;
            LoadEmployees();
        }

        public void LoadEmployees()
        {
            var employees = _dbContext.employees.ToList();
        }
        


    }
}
