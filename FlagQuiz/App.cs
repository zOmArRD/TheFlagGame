/*
 * Created by zOmArRD using Rider by JetBrains
 *
 * Date: 09/06/2004
 */

using FlagQuiz.Properties;

namespace FlagQuiz
{
    public partial class App : Form
    {
        private readonly List<string> _countries =
        [
            "Anguilla", "Antigua and Barbuda", "Argentina", "Aruba", "Bahamas", "Barbados", "Belize", "Bermuda",
            "Bolivia", "Brazil", "Canada", "Caribbean Netherlands", "Cayman Islands", "Chile", "Colombia", "Costa Rica",
            "Cuba", "Curacao", "Dominica", "Dominican Republic", "Ecuador", "Estados Unidos", "Guatemala", "Haiti",
            "Honduras", "Jamaica", "Mexico", "Nicaragua", "Panama", "Paraguay", "Peru", "Puerto Rico", "Suriname",
            "Uruguay", "Venezuela"
        ];

        private readonly List<Bitmap> _flags = [];
        private int _currentFlagIndex;
        private int _correctAnswers;
        
        public App()
        {
            InitializeComponent();
            LoadFlags();
            ShuffleFlags();
            comboBoxCountries.DataSource = new BindingSource(_countries, null);
            ShowNextFlag();
        }

        private void LoadFlags()
        {
            foreach (var country in _countries)
            {
                var resourceName = country.Replace(" ", "_");
                var flag = (Bitmap)Resources.ResourceManager.GetObject(resourceName);

                if (flag != null)
                {
                    _flags.Add(flag);
                }
                else
                {
                    MessageBox.Show($"Flag not found for {country}", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        
        private void ShuffleFlags()
        {
            Random rand = new();

            for (var i = 0; i < _flags.Count; i++)
            {
                var j = rand.Next(i, _flags.Count);

                (_flags[i], _flags[j]) = (_flags[j], _flags[i]);
                (_countries[i], _countries[j]) = (_countries[j], _countries[i]);
            }
        }

        private void ShowNextFlag()
        {
            if (_currentFlagIndex >= _flags.Count)
            {
                EvaluateResults();
                return;
            }

            submitBtn.Enabled = true;
            flagBox.Image = _flags[_currentFlagIndex];

            List<string> tempCountries = [.._countries];
            tempCountries.Shuffle();

            comboBoxCountries.DataSource = new BindingSource(tempCountries, null);
            comboBoxCountries.SelectedIndex = -1;

            resultTextBox.Text = string.Empty;
        }

        private void OnSubmit(object sender, MouseEventArgs e)
        {
            if (comboBoxCountries.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedCountry = comboBoxCountries.SelectedItem.ToString();
            var correctCountry = _countries[_currentFlagIndex];

            if (selectedCountry == correctCountry)
            {
                _correctAnswers++;
                resultTextBox.Text = "Correct!";
            }
            else
            {
                resultTextBox.Text = "Incorrect!";
            }

            _currentFlagIndex++;
            submitBtn.Enabled = false;
        }

        private void OnNext(object sender, MouseEventArgs e)
        {
            ShowNextFlag();
        }

        private void EvaluateResults()
        {
            submitBtn.Enabled = false;
            nextBtn.Enabled = false;

            var evaluation = _correctAnswers switch
            {
                5 => "fail",
                15 => "Poor",
                20 => "Good",
                24 => "Very Good!",
                _ => "Excellent!"
            };

            scoreTextBox.Text = $@"Final Score: {_correctAnswers} - {evaluation}";
        }
    }

    public static class ListExtensions
    {
        public static void Shuffle<T>(this List<T> list)
        {
            Random rng = new();

            var n = list.Count;
            while (n > 1)
            {
                n--;
                var k = rng.Next(n + 1);
                (list[k], list[n]) = (list[n], list[k]);
            }
        }
    }
}