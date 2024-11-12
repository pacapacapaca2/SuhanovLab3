using EncapsulationExample.Model;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;
using System.Windows.Forms;

namespace EncapsulationExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Чтение данных с формы
                string name = textBox1.Text;
                int age = int.TryParse(textBox2.Text, out int result) ? result : 0;

                // Создание объекта Person
                Person person = new Person
                {
                    Name = name,
                    Age = age
                };

                // Отображение информации
                label1.Text = person.GetInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
