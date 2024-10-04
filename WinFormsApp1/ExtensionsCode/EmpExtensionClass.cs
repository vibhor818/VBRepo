using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Data.Model;
namespace WinFormsApp1.ExtensionsCode
{
    public static class EmpExtensionClass
    {
       static EmpList eList;
        public static void Arjun(this DataGridView dgv)
        {
            dgv.DataSource=eList.GetEmployees();
        }
        public static void PassInstance(EmpList empList)
        {
            eList = empList;
        }
    }
}
