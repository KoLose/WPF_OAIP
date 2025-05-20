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
using System.Windows.Threading;

namespace _3thirdPractice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private TimeSpan workTime = TimeSpan.FromMinutes(0.1);
        private TimeSpan breakTime = TimeSpan.FromMinutes(0.1);
        private TimeSpan timeLeft;
        private bool isWorking = true;
        private bool isRunning = false;
        private int completedCycles = 0;

        public MainWindow()
        {
            InitializeComponent();
            timeLeft = workTime;
            UpdateTimeDisplay();
            UpdateStatusText();
        }

        private void StartPauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isRunning)
            {
                timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += Timer_Tick;
                timer.Start();
                isRunning = true;
                StartPauseButton.Content = "Пауза";
            }
            else
            {
                timer.Stop();
                isRunning = false;
                StartPauseButton.Content = "Старт";
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
            }
            isRunning = false;
            isWorking = true;
            timeLeft = workTime;
            UpdateTimeDisplay();
            UpdateStatusText();
            StartPauseButton.Content = "Старт";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));

            if (timeLeft.TotalSeconds <= 0)
            {
                timer.Stop();
                isWorking = !isWorking;

                if (isWorking)
                {
                    timeLeft = workTime;
                    MessageBox.Show("Не работай", "Pomodoro");
                    completedCycles++;
                    CyclesCountText.Text = "Количество завершённых дел: " + completedCycles.ToString();
                }
                else
                {
                    timeLeft = breakTime;
                    MessageBox.Show("Не работай!", "Помидор");
                }

                UpdateStatusText();
                timer.Start();
            }

            UpdateTimeDisplay();
        }

        private void UpdateTimeDisplay()
        {
            TimerText.Text = timeLeft.ToString(@"mm\:ss");
        }

        private void UpdateStatusText()
        {
            if (isWorking)
            {
                StatusText.Text = "Работай";
            }
            else
            {
                StatusText.Text = "Не работай";
            }
        }
    }
}