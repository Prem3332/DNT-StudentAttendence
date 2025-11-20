namespace StudentAttendence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Section sn = new Section();
            sn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            at.Show();
        }
    }
}
