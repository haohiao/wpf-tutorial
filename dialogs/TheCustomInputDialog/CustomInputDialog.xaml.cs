﻿using System;
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
using System.Windows.Shapes;

namespace TheCustomInputDialog
{
    /// <summary>
    /// CustomInputDialog.xaml 的交互逻辑
    /// </summary>
    public partial class CustomInputDialog : Window
    {
        public CustomInputDialog()
        {
            InitializeComponent();
        }

        public CustomInputDialog(string question, string answer = "")
        {
            InitializeComponent();
            QuestionLabel.Text = question;
            AnswerTextBox.Text = answer;
        }

        public string Answer
        {
            get => AnswerTextBox.Text;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            AnswerTextBox.SelectAll();
            AnswerTextBox.Focus();
        }
    }
}
