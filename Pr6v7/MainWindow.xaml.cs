using lib;
using System;
using System.Windows;

namespace Pr6v7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mItAboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант 7. Создать класс Triad (тройка чисел). Создать необходимые методы и свойства. " +
                "Определить метод сравнения триад: триада p1 больше триады р2, если(first.pl >" +
                "first.р2) или(first.pl = first.р2) и(second.pl > second.р2) и(three.pl > three.р2)." +
                "Создать перегруженные методы SetParams, для установки параметров объекта, в" +
                "том числе увеличения всех чисел на 10.",
             "Разработчик: 10.",
             MessageBoxButton.OK,
             MessageBoxImage.Information);
        }

        private void mItExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавление элементов в listbox с проверкой на корректность введенных данных с помощью конструкции try-catch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Triad triada1 = new Triad(Convert.ToInt32(txtBoxFirstNumber.Text), Convert.ToInt32(txtBoxSecondNumber.Text), Convert.ToInt32(txtBoxThirdNumber.Text)); //создание целой триады из 3-х эл-ов
                lBoxResult.Items.Add(triada1); //добавление целой триады из 3-х эл-ов
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Вывод ошибки
            }
        }

        /// <summary>
        /// Очистка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            lBoxResult.Items.Clear();
            txtBoxFirstNumber.Clear();
            txtBoxSecondNumber.Clear();
            txtBoxThirdNumber.Clear();
        }

        /// <summary>
        /// Сравнение 2-х выбранных триад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            var selectTriad = lBoxResult.SelectedItems;

            if (selectTriad.Count == 2)
            {
                Triad One = selectTriad[0] as Triad;
                Triad Two = selectTriad[1] as Triad;

                if (One.Compare(Two))
                {
                    MessageBox.Show($"Триада {One} больше триады {Two}",
                    "Результат сравнения",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show($"Триада {One} меньше {Two}",
                    "Результат сравнения",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Выделите 2 триады!!!",
                    "Ошибка",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Перегрузки: увелечение эл-ов триад на 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            var selectedTriad = lBoxResult.SelectedItems;

            if (selectedTriad.Count == 1)
            {
                Triad One = selectedTriad[0] as Triad;

                One.SetParams();
                lBoxResult.Items.Add(One);
            }
            else
            {
                MessageBox.Show("Выделите 1 триаду!!!",
                    "Ошибка",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
        }

        private void btnResult2_Click(object sender, RoutedEventArgs e)
        {
            var selectTriad = lBoxResult.SelectedItems;

            if (selectTriad.Count == 2)
            {
                Triad One = selectTriad[0] as Triad;
                Triad Two = selectTriad[1] as Triad;

                if (One>(Two))
                {
                    MessageBox.Show($"Триада {One} больше триады {Two}",
                    "Результат сравнения",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show($"Триада {One} меньше {Two}",
                    "Результат сравнения",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Выделите 2 триады!!!",
                    "Ошибка",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
        }

        private void btnCount2_Click(object sender, RoutedEventArgs e)
        {
            var selectedTriad = lBoxResult.SelectedItems;

            if (selectedTriad.Count == 1)
            {
                Triad One = selectedTriad[0] as Triad;
                One++;
                lBoxResult.Items.Add(One);
            }
            else
            {
                MessageBox.Show("Выделите 1 триаду!!!",
                    "Ошибка",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
        }
    }
}
