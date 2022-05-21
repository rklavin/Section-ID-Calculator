namespace Section_ID_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetID_Click(object sender, EventArgs e)
        {
            string[] sectionID = { "PINKAL", "REDRIA", "ORAN", "YELLOWBOZE", "WHITILL", "VIRIDIA", "GREENILL", "SKYLY", "BLUEFULL", "PURPLENUM" };

            int nameSum = 5;

            for (int i = 0; i < textBoxName.Text.Length; i++)
            {
                nameSum += (int)textBoxName.Text[i];
            }

            string nameString = nameSum.ToString();
            int nameID = int.Parse(nameString.Substring(nameString.Length - 1, 1));

            labelSectionID.Text = sectionID[nameID];
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonGetID.PerformClick();
            }
        }
    }
}