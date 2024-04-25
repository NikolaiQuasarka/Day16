namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cinema = new Cinema();
            cinema.AddEvent += delegate (object? sender, Add add)
            {
                var a = add.Movie;
                dataGridView1.Rows.Add(a.Name, a.SoundPath.Language, a.Subtitle.Language);
            };
        }
        string file = "C:\\Users\\Nikol\\OneDrive\\Рабочий стол\\Практика\\День16\\Day16\\Task1\\Language.txt";
        Cinema cinema;
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "")
            {
                string content = File.ReadAllText(file);
                if (content == "Russion")
                {
                    cinema.OrderMovie(new Movie(textBoxName.Text, new RussionSoundPath(), new RussionSubtitle()));
                }
                else if (content == "English")
                {
                    cinema.OrderMovie(new Movie(textBoxName.Text, new EnglishSoundPath(), new EnglishSubtitle()));
                }
            }
        }

        private void radioButtonRus_CheckedChanged(object sender, EventArgs e)
        {           
            File.WriteAllText(file, "Russion");
        }

        private void radioButtonEn_CheckedChanged(object sender, EventArgs e)
        {
            File.WriteAllText(file, "English");
        }
    }
}
