using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DataBindingApp {
    public partial class MainWindow : Window, INotifyPropertyChanged {
        public event PropertyChangedEventHandler? PropertyChanged;
        //public string MyBindingText { get; set; }
        //public bool IsChecked { get; set; }

        private const int minScore = 20;
        private const int maxScore = 40;

        private int score;
        private Brush foregroundColor;

        //public string ScoreTxt { get; set; }

        public int Score {
            get => score;
            set {
                this.PropertyChangeMethod(out score, value);

                //this.PropertyChangeMethod(out score, value, nameof(Score));

                //this.score = value;

                //if (this.PropertyChanged != null) {
                //    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Score)));
                //}
            }
        }
        public Brush ForegroundColor { 
            get => foregroundColor; 
            set {
                this.PropertyChangeMethod(out foregroundColor, value);

                //this.PropertyChangeMethod(out foregroundColor, value, nameof(ForegroundColor));

                //this.foregroundColor = value;

                //if (this.PropertyChanged != null) {
                //    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(ForegroundColor)));
                //}
            }
        }

        private void PropertyChangeMethod<T>(out T field, T value, [CallerMemberName]string propName = "") {
            field = value;

            if (this.PropertyChanged != null) {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propName));
            }
        }


        public MainWindow() {
            InitializeComponent();

            //this.MyBindingText = "Test";
            //this.IsChecked = true;
            this.DataContext = this;

            this.Score = minScore;
            //this.ScoreTxt = this.Score.ToString();
            this.ForegroundColor = Brushes.Red;
        }


        private void ScoreChange(object sender, RoutedEventArgs e) {
            if (sender is Button button) {
                bool isUp = button.Content.ToString() == "+";

                int score = this.Score;
                score += isUp ? 1 : -1;

                if (score >= minScore && score <= maxScore) {
                    this.Score = score;
                    //this.ScoreTxt = this.Score.ToString();

                    this.ForegroundColor = (this.Score == minScore || this.Score == maxScore)
                        ? Brushes.Red
                        : Brushes.Green;

                    //this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(ForegroundColor)));
                    //this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Score)));
                }
            }
        }


        //private void Button_Click(object sender, RoutedEventArgs e) {
        //    this.MyBindingText = "Salam";
        //    this.IsChecked = !this.IsChecked;

        //    var args = new PropertyChangedEventArgs(propertyName: nameof(MyBindingText));
        //    PropertyChanged.Invoke(this, args);

        //    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(IsChecked)));

        //    //System.Console.WriteLine($"{this.MyBindingText} - {this.MyTextBox.Text}");
        //}
    }
}
