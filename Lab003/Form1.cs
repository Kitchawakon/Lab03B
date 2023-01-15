namespace Lab003
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<double> gardes = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String name = this.Name.Text;
            String id = this.ID.Text;
            String birth = this.Birth.Text;
            String high = this.High.Text;
            String garde = this.Garde.Text;
            String SS = this.SS.Text;

            int iBirth = Int32.Parse(birth);
            double iHigh = double.Parse(high);
            double iGarde = double.Parse(garde);

            Student newStudent = new Student(name,id,iBirth,iHigh,iGarde,SS);
            this.students.Add(newStudent);
            this.gardes.Add(iGarde);

            this.Name.Text = "";
            this.ID.Text = "";
            this.Birth.Text = "";
            this.High.Text = "";
            this.Garde.Text = "";
            this.SS.Text = "";

            BindingSource source = new BindingSource();
            source.DataSource = this.students;
            this.dataGridView1.DataSource = source;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 length = students.Count;
            double MaxG = gardes.Max();
            Double MinG = gardes.Min();

            textBoxAllStd.Text= length.ToString();
            textBoxMax.Text = MaxG.ToString();
            textBoxMin.Text= MinG.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}