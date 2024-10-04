using WinFormsApp1.Data.Model;
using WinFormsApp1.ExtensionsCode;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        EmpList eList;
        public Form1()
        {
            InitializeComponent();
            eList = new EmpList();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string fName = textBox1.Text;
            //string lName = textBox2.Text;
            //int salary = Convert.ToInt32(textBox3.Text);


            Employee employee = new Employee();
            employee.EmpFirstName = textBox1.Text;
            employee.EmpLastName = textBox2.Text;
            employee.EmpSalry = Convert.ToInt32(textBox3.Text);
            eList.InsertEmployee(employee);
            ClearControls();
        }

        private void ClearControls()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpExtensionClass.PassInstance(eList);
            
            dataGridView1.Arjun();
        }
    }
}
