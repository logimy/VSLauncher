using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Security.Cryptography;
using System.IO;
using System.Reflection;
using System.Threading;

namespace VSLauncher
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };
            InitializeComponent();
            ParamFile ParamFile = new ParamFile();
            GlobalVars.originalLang = ParamFile.GetParamLang();
            GlobalVars.originalUsername = ParamFile.GetParamUserName();
            GlobalVars.originalUID = ParamFile.GetParamUID();
            GlobalVars.newLang = ParamFile.GetParamLang();
            GlobalVars.newUsername = ParamFile.GetParamUserName();
            GlobalVars.newUID = ParamFile.GetParamUID();
            Console.WriteLine("Original Lang: " + GlobalVars.originalLang);
            Console.WriteLine("Original Username: " + GlobalVars.originalUsername);
            Console.WriteLine("Original UID: " + GlobalVars.originalUID);
            Console.WriteLine("\n\n");
            Checkers Checkers = new Checkers();
            if (Checkers.isUserDataChanged())
            {
                PlayButton.Visibility = Visibility.Hidden;
                SaveButton.Visibility = Visibility.Visible;
            }
            else
            {
                PlayButton.Visibility = Visibility.Visible;
                SaveButton.Visibility = Visibility.Hidden;
            }

            if (Checkers.isUserNameOK())
            {
                if (Checkers.isUserUIDOK())
                {
                    StatusText.Text = null;
                } 
                else
                {
                    StatusText.Text = "• UID должен состоять из букв и цифр, " +
                    "не содержать пробелов " +
                    "и специальных символов и быть длиной от 6 до 32 символов.";
                }
            }
            else
            {
                StatusText.Text = "• Никнейм должен состоять из букв и цифр, " +
                "не содержать пробелов " +
                "и специальных символов и быть длиной от 3 до 16 символов.";
            }

            if (ParamFile.GetParamLang().Length > 0)
            {
                //Console.WriteLine("Current Language: " + ParamFile.GetParamLang());
                //LanguageLabel.Text = ParamFile.GetParamLang();
                if (String.Equals(GlobalVars.newLang, "en"))
                {
                    LanguageLabel.Text = "English";
                }
                else if (String.Equals(GlobalVars.newLang, "ru"))
                {
                    LanguageLabel.Text = "Русский";
                }
            }
            else
            {
                GlobalVars.newLang = "en";
                LanguageLabel.Text = "English";
            }



        }

        //public string GetHash(string input)
        //{
        //    var md5 = MD5.Create();
        //    var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

        //    return Convert.ToBase64String(hash);
        //}


        private void Window_Initialized(object sender, EventArgs e)
        {
            
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Toolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LanguageGrid.Visibility == Visibility.Hidden)
                LanguageGrid.Visibility = Visibility.Visible;
            else
                LanguageGrid.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LanguageLabel.Text = "English";
            GlobalVars.newLang = "en";
            LanguageGrid.Visibility = Visibility.Hidden;
            Checkers Checkers = new Checkers();
            //Checkers.UDRegexCheck();
            if (Checkers.isUserDataChanged())
            {
                PlayButton.Visibility = Visibility.Hidden;
                SaveButton.Visibility = Visibility.Visible;
            }
            else
            {
                PlayButton.Visibility = Visibility.Visible;
                SaveButton.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LanguageLabel.Text = "Русский";
            GlobalVars.newLang = "ru";
            LanguageGrid.Visibility = Visibility.Hidden;
            Checkers Checkers = new Checkers();
            //Checkers.UDRegexCheck();
            if (Checkers.isUserDataChanged())
            {
                PlayButton.Visibility = Visibility.Hidden;
                SaveButton.Visibility = Visibility.Visible;
            }
            else
            {
                PlayButton.Visibility = Visibility.Visible;
                SaveButton.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("VSLauncher – это программа помогающая задать ваш игровой никнейм и UID " +
                "для игры на пиратских серверах Vintage Story.\n\n" +
                "Вам нужно выбрать желаемый язык игры, ввести ваш никнейм в поле \"Ваш Никнейм\" " +
                "и ввести ваш желаемый UID в поле \"Ваш UID\". После чего необходимо сохранить настройки и запустить игру.\n\n" +
                "Ваш UID - это уникальный идентификатор для сервера, по которому сервер определяет вас и вашего персонажа " +
                "при входе в игру. Если другой игрок узнает ваш UID, он сможет зайти под вашим никнеймом и получить доступ к вашему " +
                "персонажу. Берегите свой UID и не делитесь им ни с кем.\n\n" +
                "ВАЖНО! Не вводите в поле UID свои пароли, которые вы используете при регистрации в других играх и сервисах. " +
                "Владельцы серверов видят UID каждого игрока и " +
                "могут получить несанкционированный доступ к вашим аккаунтам в случае, если вы вместо UID использовали " +
                "один из своих паролей.", "Помощь VSLauncher", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void NicknameBox_Initialized(object sender, EventArgs e)
        {
            ParamFile ParamFile = new ParamFile();
            if (ParamFile.GetParamUserName().Length > 0)
            {
                //Console.WriteLine("Current Username: " + ParamFile.GetParamUserName());
                NicknameBox.Text = ParamFile.GetParamUserName();
                Checkers Checkers = new Checkers();
                //Checkers.UDRegexCheck();
            }
        }

        private void PlayerUIDBox_Initialized(object sender, EventArgs e)
        {
            ParamFile ParamFile = new ParamFile();
            if (ParamFile.GetParamUID().Length > 0)
            {
                //Console.WriteLine("Current UID: " + ParamFile.GetParamUID());
                PlayerUIDBox.Text = ParamFile.GetParamUID();
                Checkers Checkers = new Checkers();
                //Checkers.UDRegexCheck();
            }
        }

        private void LanguageLabel_Initialized(object sender, EventArgs e)
        {
            
        }

        private void NicknameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded) { 
                GlobalVars.newUsername = NicknameBox.Text;

                Checkers Checkers = new Checkers();
                if (Checkers.isUserDataChanged())
                {
                    PlayButton.Visibility = Visibility.Hidden;
                    SaveButton.Visibility = Visibility.Visible;
                }
                else
                {
                    PlayButton.Visibility = Visibility.Visible;
                    SaveButton.Visibility = Visibility.Hidden;
                }

                if (Checkers.isUserNameOK())
                {
                    if (Checkers.isUserUIDOK())
                    {
                        StatusText.Text = null;
                    }
                    else
                    {
                        StatusText.Text = "• UID должен состоять из букв и цифр, " +
                        "не содержать пробелов " +
                        "и специальных символов и быть длиной от 6 до 32 символов.";
                    }
                }
                else
                {
                    StatusText.Text = "• Никнейм должен состоять из букв и цифр, " +
                    "не содержать пробелов " +
                    "и специальных символов и быть длиной от 3 до 16 символов.";
                }
            }
        }

        private void PlayerUIDBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                GlobalVars.newUID = PlayerUIDBox.Text;

                Checkers Checkers = new Checkers();
                if (Checkers.isUserDataChanged())
                {
                    PlayButton.Visibility = Visibility.Hidden;
                    SaveButton.Visibility = Visibility.Visible;
                }
                else
                {
                    PlayButton.Visibility = Visibility.Visible;
                    SaveButton.Visibility = Visibility.Hidden;
                }

                if (Checkers.isUserNameOK())
                {
                    if (Checkers.isUserUIDOK())
                    {
                        StatusText.Text = null;
                    }
                    else
                    {
                        StatusText.Text = "• UID должен состоять из букв и цифр, " +
                        "не содержать пробелов " +
                        "и специальных символов и быть длиной от 6 до 32 символов.";
                    }
                }
                else
                {
                    StatusText.Text = "• Никнейм должен состоять из букв и цифр, " +
                    "не содержать пробелов " +
                    "и специальных символов и быть длиной от 3 до 16 символов.";
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            
        }

        private void SaveButton_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) {
                ParamFile ParamFile = new ParamFile();
                string userNameRegexCheckPattern = "^(\\w|-){1,16}$";
                string userUIDRegexCheckPattern = "^(\\w|-){1,32}$";
                if (Regex.IsMatch(GlobalVars.newUsername, userNameRegexCheckPattern, RegexOptions.IgnoreCase)
                    && GlobalVars.newUsername.Length >= 3)
                {
                    StatusText.Text = null;
                    if (Regex.IsMatch(GlobalVars.newUID, userUIDRegexCheckPattern, RegexOptions.IgnoreCase)
                    && GlobalVars.newUID.Length >= 6)
                    {
                        ParamFile.SetParamUserData(GlobalVars.newLang, GlobalVars.newUsername, GlobalVars.newUID);
                        GlobalVars.originalLang = ParamFile.GetParamLang();
                        GlobalVars.originalUsername = ParamFile.GetParamUserName();
                        GlobalVars.originalUID = ParamFile.GetParamUID();
                        Checkers Checkers = new Checkers();
                        StatusText.Text = "Настройки успешно сохранены!";
                        if (Checkers.isUserDataChanged())
                        {
                            PlayButton.Visibility = Visibility.Hidden;
                            SaveButton.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            PlayButton.Visibility = Visibility.Visible;
                            SaveButton.Visibility = Visibility.Hidden;
                        }

                    }
                    else
                    {
                        StatusText.Text = "• UID должен состоять из букв и цифр, " +
                        "не содержать пробелов " +
                        "и специальных символов и быть длиной от 6 до 32 символов.";
                        MessageBox.Show("UID должен состоять из букв и цифр, " + "не содержать пробелов " +
                        "и специальных символов и быть длиной от 6 до 32 символов.", 
                        "Неверно введенный UID", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    StatusText.Text = "• Никнейм должен состоять из букв и цифр, " +
                        "не содержать пробелов " +
                        "и специальных символов и быть длиной от 3 до 16 символов.";
                    MessageBox.Show("Никнейм должен состоять из букв и цифр, " + "не содержать пробелов " +
                        "и специальных символов и быть длиной от 3 до 16 символов.",
                        "Неверно введенный UID", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void PlayButton_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) { 
                string gameexePath = "Vintagestory.exe";
                if (File.Exists(gameexePath))
                {
                    Process.Start("Vintagestory.exe");
                    //this.WindowState = WindowState.Minimized;
                    PlayGameBtnLabel.Content = "Игра запускается...";
                    Process[] propname = Process.GetProcessesByName("Vintagestory");
                    if (propname.Length > 0)
                    {
                        PlayGameBtnLabel.Content = "Игра запуcкается...";
                    }
                    Thread.Sleep(8000);
                    if (propname.Length > 0)
                    {
                        PlayGameBtnLabel.Content = "Игра запущена";
                    } 
                    else
                    {
                        PlayGameBtnLabel.Content = "Играть";
                    }
                }
                else
                {
                    MessageBox.Show("Файлы игры не найдены. \nПереместите лаунчер в папку с игрой.", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
